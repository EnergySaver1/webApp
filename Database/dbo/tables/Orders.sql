CREATE TABLE [dbo].[Orders]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Start_date] DATETIME NULL, 
    [End_date] NVARCHAR(50) NULL, 
    [State] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NULL, 
    [Customer_id] INT FOREIGN KEY REFERENCES Client(id) NOT NULL, 
    [Employee_id] INT FOREIGN KEY REFERENCES Employee(id)NOT NULL, 
    [Price] DECIMAL NULL, 
    [RepairType_id] INT FOREIGN KEY REFERENCES RepairType(id) NOT NULL
)
