CREATE PROCEDURE InsertSarki
	@Adi nvarchar(50),
	@SozYazari nvarchar(50),
	@Besteleyici nvarchar(50),
	@AlbumId int
AS
BEGIN
	INSERT INTO Sarkilar(Adi, SozYazari, Besteleyici, AlbumId)
	VALUES(@Adi, @SozYazari, @Besteleyici, @AlbumId)
END
GO

CREATE PROCEDURE UpdateSarki
	@Adi nvarchar(50),
	@SozYazari nvarchar(50),
	@Besteleyici nvarchar(50),
	@AlbumId int,
	@Id int
AS
BEGIN
	UPDATE Sarkilar SET Adi=@Adi, SozYazari=@SozYazari, 
		Besteleyici=@Besteleyici, AlbumId=@AlbumId 
	WHERE Id=@Id
END
GO

CREATE PROCEDURE DeleteSarki
	@Id int
AS
BEGIN
	DELETE FROM Sarkilar WHERE Id=@Id
END
GO



CREATE VIEW SelectAllSarkilar
AS
	SELECT * FROM Sarkilar
GO