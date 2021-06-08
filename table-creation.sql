--CREATE TABLE Events (
--	EventID int IDENTITY(1,1) PRIMARY KEY,
--	Title nvarchar(512) NOT NULL,
--	[Location] nvarchar(512) NOT NULL,
--	StartTime smalldatetime,
--	Price money,
--	[Description] nvarchar(2048)
--);

--CREATE TABLE Favorites (
--	FavoriteID int IDENTITY(1,1) PRIMARY KEY,
--	EventID int NOT NULL,
--	UserName nvarchar(255) NOT NULL
--);

-- Below is some dummy data added for testing purposes.

--INSERT INTO Events	(Title, 
--					[Location], 
--					StartTime, 
--					Price, 
--					[Description])
--VALUES	('Slufter''s Feel Good Sunset Live Set',
--		'Belle Isle Beach', 
--		'20210720 21:30:00', 
--		0.00, 
--		'During the sunset on Belle Isle, 
--		Slufter returns with a live set full of dance music inspired by a variety of decades and genres.');

--INSERT INTO Favorites (EventID, UserName)
--VALUES ( 1 , 'ANTONIO');