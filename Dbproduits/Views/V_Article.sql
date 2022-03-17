CREATE VIEW [dbo].[V_Article]
	AS SELECT Id, Name, Price FROM [Articles]
	Where Actif =1
