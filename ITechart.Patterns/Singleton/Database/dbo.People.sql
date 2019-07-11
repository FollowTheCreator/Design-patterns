CREATE DATABASE [SingletonDB]
GO
use SingletonDB
GO
CREATE TABLE [dbo].[People]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NULL, 
    [Age] TINYINT NULL
)
GO
INSERT INTO [People] (Name, Age) VALUES ('Alexander', 20), ('Artyom', 20), ('Evgeny', 22), ('Michael', 21)
GO
SELECT TOP 10 * FROM People