CREATE PROCEDURE [dbo].[SP_LogementsRecentsGet]
	
AS
	SELECT * 
	FROM [Logement] 
	WHERE [dateAjout] >= CONVERT (DATETIME, DATEDIFF(DAY, 30, GETDATE()))

