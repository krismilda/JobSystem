CREATE TABLE [dbo].[Jobs]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Darbas] NCHAR(30) NULL, 
    [Sritis] NCHAR(20) NULL, 
    [Darbo_pradzia] DATETIME NULL, 
    [Vieta] NCHAR(20) NULL, 
    [Alga] FLOAT NULL, 
    [Trukme] INT NULL
)
