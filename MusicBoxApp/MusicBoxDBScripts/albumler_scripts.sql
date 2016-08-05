CREATE PROCEDURE InsertAlbum
	@Adi nvarchar(50),
	@Fiyat decimal(5,2),
	@SarkiciId int
AS
BEGIN
	INSERT INTO Albumler(Adi, Fiyat,SarkiciId)
	VALUES(@Adi, @Fiyat, @SarkiciId)
END
GO

CREATE PROCEDURE UpdateAlbum
	@Adi nvarchar(50),
	@Fiyat decimal(5,2),
	@SarkiciId int,
	@Id int
AS
BEGIN
	UPDATE Albumler SET Adi=@Adi, Fiyat=@Fiyat, SarkiciId=@SarkiciId
	WHERE Id=@Id
END
GO

CREATE PROCEDURE DeleteAlbum
	@Id int
AS
BEGIN
	DELETE FROM Albumler WHERE Id=@Id
END
GO



CREATE VIEW SelectAllAlbumler
AS
	SELECT * FROM Albumler
GO