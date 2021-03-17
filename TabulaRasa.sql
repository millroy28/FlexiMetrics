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
-- Author:		<Roy,Miller>
-- Create date: <3/16/2021>
-- Description:	<Clear all user tables and data>
-- =============================================
ALTER PROCEDURE TabulaRasa 
	-- Add the parameters for the stored procedure here
	@Mode INT = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

--Mode 0 will remove just user tables
--Mode 1 will clear MasterSchema entries, Log entries, etc.

DECLARE @SQL VARCHAR(8000)


-- Get list of user created tables
	SELECT ist.TABLE_NAME AS TableName
      INTO #UserTables
	  FROM INFORMATION_SCHEMA.TABLES ist
 LEFT JOIN Structure s ON s.TableName = ist.TABLE_NAME
	 WHERE TABLE_TYPE='BASE TABLE' AND s.TableName IS NULL

-- Drop each table using dynamic sql
DECLARE @Count INT = (SELECT COUNT(TableName) FROM #UserTables)
DECLARE @TableName VARCHAR(100)

WHILE @Count > 0
  BEGIN
	SET @TableName = (SELECT TOP 1 TableName FROM #UserTables)
	SET @SQL = 'DROP TABLE ' + @TableName
	PRINT @SQL
	EXEC (@SQL)
	
	DELETE FROM #UserTables 
		  WHERE TableName = @TableName

	SET @Count = @Count - 1
  END

IF @Mode = 1
  BEGIN
	TRUNCATE TABLE ChangeRequest
	TRUNCATE TABLE ChangeLog
	DELETE FROM MasterSchema WHERE 1 = 1
  END

END
GO
