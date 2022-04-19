CREATE OR ALTER PROCEDURE SpaceFlight.GetPerson(@LastName NVARCHAR(64), @FirstName NVARCHAR(64))
AS

SELECT P.PersonId, P.FirstName, P.LastName, P.EmailAddress
FROM SpaceFlight.Person P
WHERE P.LastName = @LastName and P.FirstName = @FirstName;
GO