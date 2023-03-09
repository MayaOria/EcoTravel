CREATE PROCEDURE [dbo].[ReservationsClientGet]
	@idClient int 
AS
	SELECT * 
	FROM [Reservation]
	WHERE [idClient] = @idClient AND [dateDepart] > GETDATE() AND [dateAnnulation] is NULL


