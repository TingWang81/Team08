CREATE OR ALTER PROCEDURE SpaceFlight.InsertPerson(@FirstName NVARCHAR(64), @LastName NVARCHAR(64), @Email NVARCHAR(64))
AS 

INSERT SpaceFlight.Person(FirstName, LastName, EmailAddress)
VALUES (@FirstName, @LastName, @Email)

EXEC SpaceFlight.GetScheduledFlights @SolarSystemName = 'blah', @DestinationPlanetName = 'Venus', @DeparturePlanetID = 8
