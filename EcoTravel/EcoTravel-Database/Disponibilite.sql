CREATE TABLE [dbo].[Disponibilite]
(
	[idDisponibilite] INT NOT NULL IDENTITY, 
    [dateDebut] DATE NOT NULL DEFAULT GETDATE(), 
    [dateFin] DATE NOT NULL, 
    [idLogement] INT NOT NULL, 
    CONSTRAINT [PK_Disponibilite] PRIMARY KEY ([idDisponibilite]), 
    CONSTRAINT [CK_Disponibilite_dateDebut] CHECK ([dateDebut] >=  GETDATE()),
    CONSTRAINT [CK_Disponibilite_dateFin] CHECK ([dateFin] >  [dateDebut]), 
    CONSTRAINT [FK_Disponibilite_Logement] FOREIGN KEY ([idLogement]) REFERENCES [Logement]([idLogement]),
)
