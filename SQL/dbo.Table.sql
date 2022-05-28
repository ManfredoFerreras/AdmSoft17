CREATE TABLE [dbo].[APTOS]
(
	[AptoId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AptoCode] NCHAR(10) NOT NULL, 
    [ContactName] NVARCHAR(100) NULL, 
    [ContacDoc] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(100) NULL, 
    [PhoneNumber] NVARCHAR(50) NULL, 
    [Rented] BIT NULL
)
