CREATE TABLE [dbo].[Client]
(
	[idClient] INT NOT NULL IDENTITY, 
    [nom] NVARCHAR(50) NOT NULL, 
    [prenom] NVARCHAR(50) NOT NULL, 
    [email] NVARCHAR(255) NOT NULL, 
    [isoPays] CHAR(2) NOT NULL, 
    [telephone] NVARCHAR(50) NOT NULL, 
    [password] VARBINARY(64) NOT NULL, 
    CONSTRAINT [PK_Client] PRIMARY KEY ([idClient]), 
    CONSTRAINT [CK_Client_nom] CHECK (LEN ([nom]) >= 1 ),
    CONSTRAINT [CK_Client_prenom] CHECK (LEN ([prenom]) >= 1 ), 
    CONSTRAINT [AK_Client_email] UNIQUE ([email]),
    CONSTRAINT [CK_Client_email] CHECK ([email] LIKE ('%__@__%.__%')), 
    CONSTRAINT [CK_Client_telephone] CHECK (ISNUMERIC(REPLACE(REPLACE(REPLACE([telephone], '+', '00'), '/', ''), '.', '')) = 1)
)
