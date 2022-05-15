CREATE OR ALTER PROCEDURE SpaceFlight.GetBookedFlightsOfPerson(@PersonID INT)
AS

SELECT fp.FlightID, fp.PersonID 
FROM SpaceFlight.FlightPerson AS fp
    INNER JOIN SpaceFlight.Flight AS f ON f.FlightID = fp.FlightID
WHERE fp.PersonID = @PersonID AND f.ArrivalDateTime IS NULL