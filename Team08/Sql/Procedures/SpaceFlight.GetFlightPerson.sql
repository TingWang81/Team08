CREATE OR ALTER PROCEDURE SpaceFlight.GetFlightPerson(@FlightID INT, @PersonID INT)
AS

SELECT fp.FlightID, fp.PersonID
FROM SpaceFlight.FlightPerson AS fp
WHERE fp.FlightID = @FlightID AND fp.PersonID = @PersonID