CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NULL, 
    [Phone] INT NOT NULL, 
    [Address] VARCHAR(50) NOT NULL, 
    [Salary] DECIMAL NOT NULL, 
    [Position] VARCHAR(50) NOT NULL, 
    [DateOfEmployment] DATETIME NULL, 
    [BirthNumber] VARCHAR(50) NOT NULL
)
