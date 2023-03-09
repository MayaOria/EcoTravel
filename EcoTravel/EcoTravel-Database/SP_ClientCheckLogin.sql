CREATE PROCEDURE [dbo].[SP_ClientCheckLogin]
	@email NVARCHAR(255),
	@password NVARCHAR(32)
AS
	SELECT [idClient]
	FROM [Client]
	WHERE [email] = @email
	AND [password] = HASHBYTES('SHA2_512', @password) 
