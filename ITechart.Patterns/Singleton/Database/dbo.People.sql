create database [SingletonDB]
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
insert into [People] (Name, Age) values ('Alexander', 20), ('Artyom', 20), ('Evgeny', 22), ('Michael', 21)
GO
select top 10 * from People