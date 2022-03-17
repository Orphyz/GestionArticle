CREATE PROCEDURE [dbo].[DeleteArticle]
	@id int

AS
BEGIN

	DELETE FROM Articles

	Where Id =@id

END