--Drop table
IF OBJECT_ID('Game') IS NOT NULL DROP TABLE Game;

--Create table
CREATE TABLE Game(
	GameID int PRIMARY KEY IDENTITY,
	GameName varchar(50),
	CategoryID int,
	StudioID int,
	GamePrice int
);

--Insert data
INSERT INTO Game(GameName, CategoryID, StudioID, GamePrice) VALUES('The Crew 2', 1, 1, 825000);
INSERT INTO Game(GameName, CategoryID, StudioID, GamePrice) VALUES('Fifa 2022', 2, 2, 9900000);
INSERT INTO Game(GameName, CategoryID, StudioID, GamePrice) VALUES('Marvels Spider-Man Remastered', 3, 3, 11390000);
INSERT INTO Game(GameName, CategoryID, StudioID, GamePrice) VALUES('Counter-Strike: Global Offensive', 4, 4, 3400000);

Select *from Game

--Drop table
IF OBJECT_ID('StudioGame') IS NOT NULL DROP TABLE StudioGame;

--Create table
CREATE TABLE StudioGame(
	StudioID int PRIMARY KEY IDENTITY,
	StudioName varchar(50),
);

--Insert data
INSERT INTO StudioGame(StudioName) VALUES('Uplay');
INSERT INTO StudioGame(StudioName) VALUES('Electronic Arts');
INSERT INTO StudioGame(StudioName) VALUES('PlayStation PC LLC');
INSERT INTO StudioGame(StudioName) VALUES('Valve');


Select *from StudioGame

--Drop table
IF OBJECT_ID('CategoryGame') IS NOT NULL DROP TABLE CategoryGame;

--Create table
CREATE TABLE CategoryGame(
	CategoryGameID int PRIMARY KEY IDENTITY,
	CategoryGameName varchar(50),
);

--Insert data
INSERT INTO CategoryGame(CategoryGameName) VALUES('Racing');
INSERT INTO CategoryGame(CategoryGameName) VALUES('Esport');
INSERT INTO CategoryGame(CategoryGameName) VALUES('Action');
INSERT INTO CategoryGame(CategoryGameName) VALUES('Shooting');

Select *from CategoryGame