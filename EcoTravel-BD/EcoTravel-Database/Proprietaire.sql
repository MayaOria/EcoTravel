CREATE TABLE [dbo].[Proprietaire]
(
	[idClient] INT NOT NULL PRIMARY KEY, 
    CONSTRAINT [FK_Proprietaire_Client] FOREIGN KEY ([idClient]) REFERENCES [Client]([idClient])
)
