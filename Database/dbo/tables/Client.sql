CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NULL, 
    [Phone] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NOT NULL
)
