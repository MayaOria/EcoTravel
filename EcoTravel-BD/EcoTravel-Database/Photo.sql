CREATE TABLE [dbo].[Photo]
(
	[idPhoto] INT NOT NULL IDENTITY, 
    [source] NVARCHAR(255) NOT NULL, 
    [idLogement] INT NOT NULL, 
    CONSTRAINT [PK_Photo] PRIMARY KEY ([idPhoto]), 
    CONSTRAINT [CK_Photo_source] CHECK (LEN([source]) >= 5 AND ([source] LIKE '%_.png' OR [source] LIKE '%_.jpg')), 
    CONSTRAINT [FK_Photo_Logement] FOREIGN KEY ([idLogement]) REFERENCES [Logement]([idLogement]), 
    CONSTRAINT [AK_Photo_source] UNIQUE ([source])

    
)
