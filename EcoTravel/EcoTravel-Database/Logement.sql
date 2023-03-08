﻿CREATE TABLE [dbo].[Logement]
(
	[idLogement] INT NOT NULL IDENTITY, 
    [nom] NVARCHAR(255) NOT NULL, 
    [descriptionCourte] NVARCHAR(255) NOT NULL, 
    [descriptionLongue] NVARCHAR(MAX) NOT NULL, 
    [prixJournalier] MONEY NOT NULL DEFAULT 0, 
    [nbChambres] TINYINT NOT NULL DEFAULT 1, 
    [nbPieces] TINYINT NOT NULL DEFAULT 3, 
    [capacite] TINYINT NOT NULL DEFAULT 2, 
    [nbSDB] TINYINT NOT NULL DEFAULT 1, 
    [nbWC] TINYINT NOT NULL DEFAULT 1, 
    [balcon] BIT NOT NULL DEFAULT 0 , 
    [wifi] BIT NOT NULL DEFAULT 0, 
    [airco] BIT NOT NULL DEFAULT 0, 
    [minibar] BIT NOT NULL DEFAULT 0, 
    [animaux] BIT NOT NULL DEFAULT 0, 
    [piscine] BIT NOT NULL DEFAULT 0, 
    [voiturier] BIT NOT NULL DEFAULT 0, 
    [roomService] BIT NOT NULL DEFAULT 0, 
    [idAdresse] INT NOT NULL, 
    [idClient] INT NOT NULL, 
    [dateAjout] DATE NOT NULL DEFAULT GETDATE(), 
    CONSTRAINT [PK_Logement] PRIMARY KEY ([idLogement]), 
    CONSTRAINT [CK_Logement_nom] CHECK (LEN ([nom]) >= 1 ),
    CONSTRAINT [CK_Logement_descriptionCourte] CHECK (LEN ([descriptionCourte]) >= 1 ),
    CONSTRAINT [CK_Logement_descriptionLongue] CHECK (LEN ([descriptionLongue]) >= 1 ), 
    CONSTRAINT [CK_Logement_prixJournalier] CHECK ([prixJournalier] >= 0),
    CONSTRAINT [CK_Logement_nbChambres] CHECK ([nbChambres] >= 1),
    CONSTRAINT [CK_Logement_nbPieces] CHECK ([nbPieces] >= 1),
    CONSTRAINT [CK_Logement_capacite] CHECK ([capacite] >= 1),
     
    CONSTRAINT [FK_Logement_Adresse] FOREIGN KEY ([idAdresse]) REFERENCES [Adresse]([idAdresse]), 
    CONSTRAINT [FK_Logement_Proprietaire] FOREIGN KEY ([idClient]) REFERENCES [Proprietaire]([idClient]), 
    CONSTRAINT [CK_Logement_dateAjout] CHECK ([dateAjout] >= GETDATE()),
    
)
