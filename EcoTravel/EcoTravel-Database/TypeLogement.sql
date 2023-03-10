CREATE TABLE [dbo].[TypeLogement]
(
	[idTypeLogement] INT NOT NULL IDENTITY, 
    [nom] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_TypeLogement] PRIMARY KEY ([idTypeLogement]), 
    CONSTRAINT [AK_TypeLogement_nom] UNIQUE ([nom]) 
)
