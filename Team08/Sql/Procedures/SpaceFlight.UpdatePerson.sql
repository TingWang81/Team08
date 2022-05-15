CREATE OR ALTER PROCEDURE SpaceFlight.UpdatePerson(@PersonID INT, @FirstName NVARCHAR(64), @LastName NVARCHAR(64), @EmailAddress NVARCHAR(64))
AS
UPDATE SpaceFlight.Person
SET FirstName = @FirstName, LastName = @LastName, EmailAddress = @EmailAddress
WHERE PersonID = @PersonID

SELECT *
FROM SpaceFlight.Flight

DELETE SpaceFlight.Person
WHERE FirstName = 'John' AND LastName = 'Keller'