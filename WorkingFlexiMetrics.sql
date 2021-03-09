use FlexiMetrics

CREATE TABLE UserSchema (
SchemaID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
TableName VARCHAR (100),
ColumnName VARCHAR (100),
ColumnType VARCHAR (100),
Active BIT
)

CREATE TABLE SchemaStatus(
SchemaStatusID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
StatusName VARCHAR(20)
)

CREATE TABLE SchemaLog (
SchemaLogID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
SchemaID INT FOREIGN KEY REFERENCES UserSchema(SchemaID),
SchemaStatusID INT FOREIGN KEY REFERENCES SchemaStatus(SchemaStatusID),
[Date] DATETIME,
Author INT
)

CREATE TABLE ChangeType (
ChangeTypeID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
ChangeName VARCHAR(20)
)


CREATE TABLE ChangeRequest (
ChangeRequestID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Author INT,
SchemaID INT FOREIGN KEY REFERENCES UserSchema(SchemaID),
ChangeTypeID INT FOREIGN KEY REFERENCES ChangeType(ChangeTypeID),
NewValue VARCHAR(100),
ValueType VARCHAR(100),
ParentID INT
)

CREATE TABLE ChangeLog (
Author INT,
SchemaID INT FOREIGN KEY REFERENCES UserSchema(SchemaID),
ChangeTypeID INT FOREIGN KEY REFERENCES ChangeType(ChangeTypeID),
OldValue VARCHAR(100),
NewValue VARCHAR(100),
OldStatusID INT,
NewStatusID INT,
[DATE] DATETIME)


INSERT INTO ChangeType (ChangeName) VALUES
('Add Table'),
('Drop Table'),
('Change Table Name'),
('Add Column'),
('Alter Column Name'),
('Alter Column Type'),
('Drop Column'),
('Add Foreign Key')


