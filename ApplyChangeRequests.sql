-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Roy Miller
-- Create date: 3/11/2021
-- Description:	Create tables/table changes from user submitted requests
-- =============================================
ALTER PROCEDURE ApplyChangeRequests 
	-- Add the parameters for the stored procedure here
	@ChangeRequestID INT,
	@UserID INT = -1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
    -- Insert statements for procedure here
	/*
	Modes: ( from Changetype table)
	Add Table
	Drop Table
	Change Table Name
	Add Column
	Alter Column Name
	Alter Column Type
	Drop Column
	Add Foreign Key
	*/

--Get Mode to run in
DECLARE @Mode VARCHAR(20)

SELECT @Mode = ct.ChangeName
  FROM ChangeRequest cr
  JOIN ChangeType ct ON cr.ChangeTypeID = ct.ChangeTypeID
 WHERE cr.ChangeRequestID = @ChangeRequestID

PRINT 'Mode: ' + @Mode

IF @Mode = 'Add Table'
  BEGIN
	--Build and execute Create Table statement from values in Change Request table using dynamic SQL
	DECLARE @SQL VARCHAR(MAX)
	DECLARE @TableName VARCHAR(100)

	CREATE TABLE #TableToAdd (RowNum INT IDENTITY(0,1), SQLName VARCHAR (100), FacingName VARCHAR (100), SQLType VARCHAR (100), FacingType VARCHAR (100), ParentID INT)

	INSERT INTO #TableToAdd (FacingName, FacingType, ParentID)
	SELECT NewValue, ValueType, ParentID
	  FROM ChangeRequest
	 WHERE ChangeRequestID = @ChangeRequestID OR ParentID = @ChangeRequestID

	UPDATE s
	   SET s.SQLName = '[' + s.FacingName + ']',
		   s.SQLType = s.SQLTerm
	  FROM (SELECT ftst.SQLTerm, tta.FacingName, tta.SQLName, tta.SQLType
			  FROM #TableToAdd tta
		 LEFT JOIN FrontToSQLTerms ftst ON tta.FacingType = ftst.FrontFacingTerm) s

	 	
	SET @TableName = (SELECT tta.SQLName FROM #TableToAdd tta WHERE tta.SQLType IS NULL)

	SET @SQL = 'CREATE TABLE ' + @TableName + ' ('

	 ;WITH Concat_Columns AS (
	SELECT RowNum, 
		   CONVERT(NVarchar(1000), tta.SQLName + ' ' + tta.SQLType) AS ColumnDefs
	  FROM #TableToAdd tta
     WHERE tta.ParentID IS NOT NULL
	), Concatenated AS (
	SELECT RowNum, 
		   ColumnDefs as ColumnDefs
	  FROM Concat_Columns
	 WHERE RowNum = 1
	 UNION ALL
	SELECT cc.RowNum, 
		   CONVERT(NVARCHAR(1000), c.ColumnDefs + ', ' + cc.ColumnDefs)
	  FROM Concat_Columns cc 
	  JOIN Concatenated c ON cc.RowNum = c.RowNum + 1
	)
	SELECT TOP 1 @SQL = @SQL + ColumnDefs + ')'
	  FROM Concatenated
	  ORDER BY RowNum DESC

	PRINT 'Create Table Statement: ' + @SQL
	EXEC (@SQL)

	--Record new table in MasterSchema table
	DECLARE @ParentID TABLE (Id INT)
	
	INSERT INTO MasterSchema (SQLName, FacingName, SQLType, FacingType, Active, PermissionLevel) 
	OUTPUT inserted.SchemaID INTO @ParentID
	SELECT tta.SQLName, tta.FacingName, tta.SQLType, tta.FacingType, 1, 1
	  FROM #TableToAdd tta
	 WHERE tta.ParentID IS NULL

	INSERT INTO MasterSchema (SQLName, FacingName, SQLType, FacingType, Active, PermissionLevel, ParentSchemaID)
	SELECT tta.SQLName, tta.FacingName, tta.SQLType, tta.FacingType, 1, 1, pid.Id
	  FROM #TableToAdd tta
	  JOIN @ParentID pid ON 1 = 1
	 WHERE tta.ParentID IS NOT NULL

	 --Log changes. ChangeTypeID 1 = Add Table; 4 = Add Column
	INSERT INTO ChangeLog (ChangeTypeID, NewValue, SchemaID, UserID, [TimeStamp])
	SELECT 1, ms.SQLName, pid.Id, @UserID, GETDATE()
	  FROM MasterSchema ms 
	  JOIN @ParentID pid ON 1 = 1
	 WHERE ms.SchemaID = pid.Id

	INSERT INTO ChangeLog (ChangeTypeID, NewValue, SchemaID, UserID, [TimeStamp])
	SELECT 4, ms.SQLName, ms.SchemaID, @UserID, GETDATE()
	  FROM MasterSchema ms
	  JOIN @ParentID pid ON 1 = 1
     WHERE ms.ParentSchemaID = pid.ID

	 --Remove entries from Change Request table
	DELETE FROM ChangeRequest 
	 WHERE ParentID = @ChangeRequestID OR ChangeRequestID = @ChangeRequestID
	RETURN

  END

END
GO
