
Create database SampleLoginDb 

use SampleLoginDb

CREATE TABLE Users(id INTEGER PRIMARY KEY IDENTITY(101,1), FirstName VARCHAR(20) , LastName VARCHAR(20), Place VARCHAR(20));

INSERT INTO Users VALUES(101 , 'Akhil' , 'Mohan' , 'Erode' ),  
						(102 , 'Arjun' , 'Kumar' , 'Chennai' ),
						(103 , 'Ram' , 'Sai' , 'Bangalore' ),
						(104 , 'Bala' , 'Das' , 'Hyderabad' ),
						(105 , 'Raj' , 'Kumar' , 'Kochi' ) 

select * from Users


CREATE PROCEDURE ADD_USERS @firstName VARCHAR(20), @lastName VARCHAR(20), @place VARCHAR(20)
AS
BEGIN
insert into Users(FirstName,LastName,Place) values(@firstName, @lastName, @place);
END
GO

CREATE PROCEDURE UPDATE_USERS_FIRSTNAME @id INTEGER, @value VARCHAR(20)
AS
BEGIN
UPDATE Users SET FirstName = @value WHERE id = @id;
END 
GO

CREATE PROCEDURE UPDATE_USERS_LASTNAME @id INTEGER, @value VARCHAR(20)
AS
BEGIN
UPDATE Users SET LastName = @value WHERE id = @id;
END 
GO

CREATE PROCEDURE UPDATE_USERS_PLACE @id INTEGER, @value VARCHAR(20)
AS
BEGIN
UPDATE Users SET Place = @value WHERE id = @id;
END 
GO

CREATE PROCEDURE DELETE_USERS @id INTEGER
AS 
BEGIN 
DELETE FROM Users WHERE id = @id;
END 
GO



