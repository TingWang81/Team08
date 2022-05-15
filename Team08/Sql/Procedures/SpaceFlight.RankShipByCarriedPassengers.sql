CREATE OR ALTER PROCEDURE SpaceFlight.RankShipByTotalNumPassengers
AS

SELECT f.ShipID, ss.ShipName, ss.ShipTypeID, COUNT(DISTINCT fp.PersonID) AS NumPassengers
FROM SpaceFlight.FlightPerson AS fp
    INNER JOIN SpaceFlight.Flight AS f ON f.FlightID = fp.FlightID
    INNER JOIN SpaceFlight.SpaceShip AS ss ON ss.ShipID = f.ShipID
GROUP BY f.ShipID, ss.ShipName, ss.ShipTypeID
ORDER BY NumPassengers DESC

-- EXEC SpaceFlight.RankShipByTotalNumPassengers