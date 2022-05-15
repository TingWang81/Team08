CREATE OR ALTER PROCEDURE SpaceFlight.DeleteFlightPerson(@FlightID INT, @PersonID INT)
AS
DELETE FROM SpaceFlight.FlightPerson
WHERE FlightID = @FlightID AND PersonID = @PersonID