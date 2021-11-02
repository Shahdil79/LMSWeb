CREATE DATABASE Library

Use Library

CREATE TABLE Category
(
categoryId INT IDENTITY NOT NULL PRIMARY KEY,
name NVARCHAR(500) NULL,
parentId INT NOT NULL default(0)
)

CREATE TABLE Book
(
bookId INT IDENTITY NOT NULL PRIMARY KEY,
name nvarchar(500) NULL,
authorName nvarchar(500) NULL,
categoryId INT NULL,
FOREIGN KEY (categoryId) REFERENCES Category(categoryId)
)

--Inserting in Category Table 
Insert into Category(name,parentId)
Values ('Science',NULL)

Insert into Category(name,parentId)
Values ('Biography',NULL)

Insert into Category(name,parentId)
Values ('Information Technology',NULL)

Insert into Category(name,parentId)
Values ('Computer Science',1)

Insert into Category(name,parentId)
Values ('Medical Science',1)

Insert into Category(name,parentId)
Values ('Networking',3)

Insert into Category(name,parentId)
Values ('Programming',3)

Insert into Category(name,parentId)
Values ('Actors Biography',2)



--Inserting in Book Table
Insert into Book(name,authorName,CategoryId)
Values ('BookScience','John',1)

Insert into Book(name,authorName,CategoryId)
Values ('Shahrukh','Niku',2)

Insert into Book(name,authorName,CategoryId)
Values ('C# in CodeLab','Mike',3)

Insert into Book(name,authorName,CategoryId)
Values ('.Net','Microsft',3)

Insert into Book(name,authorName,CategoryId)
Values ('HandsOn Practise','Jimmy',3)

Insert into Book(name,authorName,CategoryId)
Values ('Amir Khan','Amit Mehta',2)



--For Fetching Books Record
CREATE PROC sp_GetBooks
AS 
BEGIN
Select bookId,name,authorName,categoryId from Book
END  




