CREATE TABLE [dbo].[Reservation]
(
	[idReservation] INT NOT NULL IDENTITY, 
    [dateArrivee] DATE NOT NULL DEFAULT GETDATE(), 
    [dateDepart] DATE NOT NULL, 
    [dateAnnulation] DATE NULL, 
    [nbEnfants] TINYINT NOT NULL DEFAULT 0, 
    [nbAdultes] TINYINT NOT NULL DEFAULT 2, 
    [assurance] BIT NOT NULL DEFAULT 0, 
    [idLogement] INT NOT NULL, 
    [idClient] INT NOT NULL, 
    CONSTRAINT [PK_Reservation] PRIMARY KEY ([idReservation]), 
    CONSTRAINT [CK_Reservation_dateArrivee] CHECK ([dateArrivee] >= GETDATE()),
    CONSTRAINT [CK_Reservation_dateDepart] CHECK ([dateDepart] > [dateArrivee]),
    CONSTRAINT [CK_Reservation_dateAnnulation] CHECK ([dateAnnulation] < [dateDepart]),
    CONSTRAINT [CK_Reservation_nbAdultes] CHECK ([nbAdultes] >= 1), 
    CONSTRAINT [FK_Reservation_Logement] FOREIGN KEY ([idLogement]) REFERENCES [Logement]([idLogement]), 
    CONSTRAINT [FK_Reservation_Client] FOREIGN KEY ([idClient]) REFERENCES [Client]([idClient]),
)
