CREATE TABLE [dbo].[Coordonnees]
(
	[idCoordonnees] INT NOT NULL IDENTITY, 
    [latitude] DECIMAL(10, 8) NOT NULL, 
    [longitude] DECIMAL(11, 8) NOT NULL, 
    CONSTRAINT [PK_Coordonnees] PRIMARY KEY ([idCoordonnees]), 
   
)
