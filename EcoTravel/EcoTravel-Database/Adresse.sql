CREATE TABLE [dbo].[Adresse]
(
	[idAdresse] INT NOT NULL IDENTITY, 
    [rue] NVARCHAR(255) NOT NULL, 
    [numero] NVARCHAR(50) NOT NULL, 
    [codePostal] NVARCHAR(50) NOT NULL, 
    [isoPays] CHAR(2) NOT NULL, 
    [latitude] DECIMAL(10, 8) NOT NULL, 
    [longitude] DECIMAL(11, 8) NOT NULL, 
    CONSTRAINT [PK_Adresse] PRIMARY KEY ([idAdresse]), 
    CONSTRAINT [CK_Adresse_rue] CHECK (LEN ([rue]) >= 1 ),
    
)
