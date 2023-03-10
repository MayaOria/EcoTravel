CREATE PROCEDURE [dbo].[SP_ClientAdd]
	@nom NVARCHAR(50),
	@prenom NVARCHAR(50),
	@email NVARCHAR(255),
	@isoPays CHAR(2),
	@telephone NVARCHAR(50),
	@password NVARCHAR(32)
AS
	INSERT INTO [Client]([nom], [prenom], [email], [isoPays], [telephone], [password])
	OUTPUT [inserted].[idClient]
	VALUES (@nom, @prenom, @email, @isoPays, @telephone, HASHBYTES('SHA2_512', @password))

