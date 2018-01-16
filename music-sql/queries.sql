SELECT * FROM Genre;
INSERT INTO Artist(ArtistID, ArtistName, YearEstablished)
VALUES(null, 'Hanson', 1992);

INSERT INTO Album(AlbumId, Title, ReleaseDate, AlbumLength, Label, ArtistId, GenreId)
VALUES(null, 'Underneath', '4/20/2004', 3628, '3CG', 28, 7);

INSERT INTO Album(AlbumId, Title, ReleaseDate, AlbumLength, Label, ArtistId, GenreId)
VALUES(null, 'Shout It Out', '6/8/2010', 2969, '3CG', 28, 7);

INSERT INTO Song(SongId, Title, SongLength, ReleaseDate, GenreId, ArtistId, AlbumId)
VALUES(null, 'Strong Enough to Break', 212, '4/20/2004', 7, 28, 27);

INSERT INTO Song(SongId, Title, SongLength, ReleaseDate, GenreId, ArtistId, AlbumId)
VALUES(null, 'Penny & Me', 243, '4/20/2004', 7, 28, 27);

INSERT INTO Song(SongId, Title, SongLength, ReleaseDate, GenreId, ArtistId, AlbumId)
VALUES(null, 'Give a Little', 225, '6/8/2010', 7, 28, 28);

INSERT INTO Song(SongId, Title, SongLength, ReleaseDate, GenreId, ArtistId, AlbumId)
VALUES(null, 'Waiting for This', 197, '6/8/2010', 7, 28, 28);

SELECT s.Title, a.Title, n.ArtistName 
FROM Song s 
LEFT JOIN Album a 
ON s.AlbumId = a.AlbumId
LEFT JOIN Artist n
ON s.ArtistId = n.ArtistId
WHERE n.ArtistName = 'Hanson';

SELECT a.Title, count(*)
FROM Song s
LEFT JOIN Album a 
ON a.AlbumId = s.AlbumId
GROUP BY s.AlbumId
;

SELECT n.ArtistName, count(*)
FROM Song s
LEFT JOIN Artist n
ON n.ArtistId = s.ArtistId
GROUP By s.ArtistId;

SELECT g.Label, count(*)
FROM Song s
LEFT JOIN Genre g
ON g.GenreId = s.GenreID
GROUP BY g.GenreId;

SELECT Title, MAX(AlbumLength)
FROM Album;

SELECT s.Title, a.Title, MAX(s.SongLength)
FROM Song s
LEFT JOIN Album a
ON s.AlbumId = a.AlbumId;


