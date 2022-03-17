CREATE TRIGGER [DeleteTrigger]
ON [dbo].[Articles]
INSTEAD OF Delete
AS
BEGIN
	SET NOCOUNT ON
	UPDATE Article SET Active = 0 WHERE Id =(SELECT id FROM deleted)
END
