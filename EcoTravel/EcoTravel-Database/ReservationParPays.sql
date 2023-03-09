CREATE VIEW [dbo].[ReservationParPays]

	AS SELECT [Reservation].*, [Adresse].isoPays 
	FROM [Reservation]
	JOIN [Logement]
	ON [Reservation].[idLogement] = [Logement].[idLogement]
	JOIN [Adresse]
	ON [Logement].[idAdresse] = [Adresse].[idAdresse]
	
	
