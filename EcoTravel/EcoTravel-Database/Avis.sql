CREATE TABLE [dbo].[Avis]
(
	[idAvis] INT NOT NULL IDENTITY, 
    [description] NVARCHAR(MAX) NULL, 
    [idReservation] INT NOT NULL, 
    [dateAvis] DATE NOT NULL DEFAULT GETDATE(), 
    [note] TINYINT NOT NULL, 
    CONSTRAINT [PK_Avis] PRIMARY KEY ([idAvis]), 
    CONSTRAINT [CK_Avis_description] CHECK ([description] >= 2), 
    CONSTRAINT [FK_Avis_Reservation] FOREIGN KEY ([idReservation]) REFERENCES [Reservation]([idReservation]), 
    CONSTRAINT [CK_Avis_note] CHECK ([note] <= 5)
    
    
)
