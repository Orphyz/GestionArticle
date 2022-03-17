CREATE PROCEDURE [dbo].[UpdateArticle]
	@Name Varchar(50),
	@Description Varchar(200),
	@EAN13 Varchar(13), 
	@Price Float
AS
BEGIN
	UPDATE Articles
	SET Name =@Name,
		Description =@Description,
		EAN13= @EAN13,
		Price= @Price

END
