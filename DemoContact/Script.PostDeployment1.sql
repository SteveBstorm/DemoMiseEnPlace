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


INSERT INTO Movie (Title, IsFavorite) VALUES ('Star Wars', 1)
INSERT INTO Movie (Title, IsFavorite) VALUES ('Indiana Jones', 0)

INSERT INTO Actors (LastName, FirstName) VALUES ('Harisson', 'Ford')
INSERT INTO Actors (LastName, FirstName) VALUES ('Mark', 'Hammil')

INSERT INTO Casting (ActorId, MovieId) VALUES (1, 1)
INSERT INTO Casting (ActorId, MovieId) VALUES (1, 2)
INSERT INTO Casting (ActorId, MovieId) VALUES (2, 1)