CREATE PROCEDURE [dbo].[AddArticle]
	@Name varchar(50),
	@Description varchar(50),
	@EAN13 Varchar(13),
	@Price FLOAT
AS
Begin
	INSERT INTO Articles (Name, Description, EAN13, Price) values (@Name, @Description , @EAN13, @Price)
End