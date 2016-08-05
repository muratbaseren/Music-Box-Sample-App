CREATE PROCEDURE InsertSarkici
	@Adi nvarchar(50),
	@Soyadi nvarchar(50),
	@TurId int
AS
BEGIN
	INSERT INTO Sarkicilar(Adi,Soyadi,TurId)
	VALUES(@Adi, @Soyadi, @TurId)
END
GO

CREATE PROCEDURE UpdateSarkici
	@Adi nvarchar(50),
	@Soyadi nvarchar(50),
	@TurId int,
	@Id int
AS
BEGIN
	UPDATE Sarkicilar SET Adi=@Adi, Soyadi=@Soyadi, 
	TurId=@TurId WHERE Id=@Id
END
GO

CREATE PROCEDURE DeleteSarkici
	@Id int
AS
BEGIN
	DELETE FROM Sarkicilar WHERE Id=@Id
END
GO


CREATE VIEW SelectAllSarkicilar
AS
	SELECT * FROM Sarkicilar
GO