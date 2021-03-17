use FlexiMetrics

CREATE TABLE MasterSchema (
SchemaID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
SQLName VARCHAR (100),
FacingName VARCHAR (100),
SQLType VARCHAR (100),
FacingType VARCHAR (100),
ParentSchemaID INT,
Active BIT,
PermissionLevel INT
)

CREATE TABLE PermissionLevels(
PermissionLevelID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
PermissionLevel VARCHAR(20)
)

--Drop table SchemaTypes
--CREATE TABLE SchemaTypes(
--SchemaTypeID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
--SchemaType VARCHAR(20),
--)
--drop table SchemaChangeType
--CREATE TABLE SchemaChangeType(
--SchemaChangeTypeID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
--ChangeType VARCHAR(20)
--)
--drop table SchemaLog
--CREATE TABLE SchemaLog (
--SchemaLogID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
--SchemaID INT FOREIGN KEY REFERENCES MasterSchema(SchemaID),
--ChangeTypeID INT FOREIGN KEY REFERENCES ChangeType(ChangeTypeID),
--[Date] DATETIME,
--UserId INT
--)
--drop table UserSchema


CREATE TABLE ChangeType (
ChangeTypeID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
ChangeName VARCHAR(20)
)

CREATE TABLE ChangeRequest (
ChangeRequestID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
UserID INT,
SchemaID INT FOREIGN KEY REFERENCES MasterSchema(SchemaID),
ChangeTypeID INT FOREIGN KEY REFERENCES ChangeType(ChangeTypeID),
NewValue VARCHAR(100),
ValueType VARCHAR(100),
ParentID INT
)

CREATE TABLE ChangeLog (
UserID INT,
SchemaID INT FOREIGN KEY REFERENCES MasterSchema(SchemaID),
ChangeTypeID INT FOREIGN KEY REFERENCES ChangeType(ChangeTypeID),
OldValue VARCHAR(100),
NewValue VARCHAR(100),
[TimeStamp] DATETIME)


INSERT INTO ChangeType (ChangeName) VALUES
('Add Table'),
('Drop Table'),
('Change Table Name'),
('Add Column'),
('Alter Column Name'),
('Alter Column Type'),
('Drop Column'),
('Add Foreign Key'),
('Change Permission')

CREATE TABLE FrontToSQLTerms (
FrontFacingTerm VARCHAR(30),
SQLTerm VARCHAR(20),
SqlTermTypeID INT FOREIGN KEY REFERENCES ChangeType(ChangeTypeID),
)


CREATE TABLE SQLTermTypes(
SQLTermTypeID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
SQLTermType VARCHAR(20)
)

INSERT INTO SQLTermTypes (SQLTermType) VALUES
('DataType')

INSERT INTO FrontToSQLTerms (FrontFacingTerm, SQLTerm, SqlTermTypeID) VALUES
('Integer', 'INT', 1),
('Money', 'MONEY', 1),
('Decimal Value Numbers', 'DECIMAL', 1),
('Dates and Times', 'DATETIME', 1),
('Binary Value', 'BIT', 1),
('Small string', 'VARCHAR(10)', 1),
('Medium string', 'VARCHAR(50)', 1),
('Large string', 'VARCHAR(500)', 1),
('Maximum string', 'VARCHAR(MAX)', 1)

INSERT INTO PermissionLevels (PermissionLevel) VALUES 
('Private'),
('Read Only'),
('Specific Read Only'),
('Edit/Delete'),
('Specific Edit/Delete')

CREATE TABLE Structure (TableName VARCHAR(100))
INSERT INTO Structure (TableName) VALUES 
('PermissionLevels'),
('SQLTermTypes'),
('FrontToSQLTerms'),
('MasterSchema'),
('ChangeLog'),
('ChangeRequest'),
('ChangeType'),
('Structure')

