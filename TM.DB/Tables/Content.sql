CREATE TABLE [dbo].[Content]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[Type] VARCHAR(64) NOT NULL,
	[Value] VARCHAR(1023) NULL, 
    [Header] VARCHAR(512) NULL, 
    [Subheader] VARCHAR(512) NULL, 
    [Order] INT NULL,
	[Year] INT NULL,
    [IsDeleted] BIT NOT NULL DEFAULT 0, 
)