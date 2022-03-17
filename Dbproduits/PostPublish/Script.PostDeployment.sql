/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
Set Identity_insert Articles on;
INSERT INTO Articles(Id, Name, Description, EAN13, Price) VALUES

(1, 'Médicaments essentiels', 'Guide pratique d''utilisation des médicaments éssentiels', 9782906498624, 12.27),
(2, 'Myst III','La suite de Myst et Riven', 3307212306508, 23.23),
(3, 'Pegasus Seiya Mythcloth', 'Figurine Anime Heroes', 3296580369218, 123.52),
(4, 'Phoenix Ikki Mythcloth', 'Figurine Anime Heroes', 3296580369263, 145.78),
(5, 'Paw Patrol:Tous à la piscine!', 'Livre des aventures de la Pat''Patrouille', 9782014648492, 5.60),
(6, '111 years of Deursche Grammophon', 'Coffret DVD', 044007345665, 27.21)
Set Identity_insert Articles OFF;
