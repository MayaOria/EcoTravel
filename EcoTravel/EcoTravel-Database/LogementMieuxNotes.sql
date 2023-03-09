CREATE VIEW [dbo].[LogementMieuxNotes]
	AS SELECT [L].* FROM [Logement] AS L
	JOIN [Reservation]
	ON [Reservation].[idLogement] = [L].[idLogement]
	JOIN [Avis]
	ON [Avis].[idReservation] = [Reservation].[idReservation]
	WHERE (SELECT AVG([Avis].[note]) FROM [Avis] JOIN [Reservation] ON [Avis].[idReservation] = [Reservation].[idReservation] WHERE [Reservation].[idLogement] = L.[idLogement] ) > (SELECT AVG([note]) FROM [Avis])
