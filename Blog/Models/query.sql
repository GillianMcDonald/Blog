SELECT * FROM userDB;

SELECT * FROM blogDB;

SELECT * 
FROM (SELECT imageThumbURL,
             blogName,
             blogShort,
             userName

FROM blogDB)
AS b1;

SELECT *
FROM (SELECT imageURL,
             blogName,
             blogActual,
             userName

      FROM blogDB)
         AS b2;

INSERT INTO userDB(firstName, lastName, userName, email, password)
VALUES
('Rod', 'Stewart', 'RDog', 'Rod@Rod.com','RodMcRoderson');


INSERT INTO blogDB(blogName, blogShort, blogActual, imageURL, imageThumbURL, blogweek, userID, userName)
VALUES
('I cant code', 'This is the short Description', 'This is the Blog', '/images/thumbnail.jpg', '/images/thumbnail.jpg', 'False', 1, 'Jdog');