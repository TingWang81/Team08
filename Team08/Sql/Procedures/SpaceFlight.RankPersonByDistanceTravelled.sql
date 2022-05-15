CREATE OR ALTER PROCEDURE SpaceFlight.RankPersonByDistanceTravelled
AS 

WITH cte
AS
(
SELECT f.FlightID, pl.XCoordinate AS DestXCoordinate, pl.YCoordinate AS DestYCoordinate, p.XCoordinate AS DepartXCoordinate, p.YCoordinate AS DepartYCoordinate
FROM SpaceFlight.Planet AS p 
    INNER JOIN SpaceFlight.Flight AS f ON f.DeparturePlanetID = p.PlanetID
    INNER JOIN SpaceFlight.Planet AS pl ON f.DestinationPlanetID = pl.PlanetID
)

SELECT p.PersonID, p.FirstName, p.LastName, p.EmailAddress,
    SUM(SQRT(((cte.DestXCoordinate - cte.DepartXCoordinate)*(cte.DestXCoordinate - cte.DepartXCoordinate)) + ((cte.DestYCoordinate - cte.DepartYCoordinate)*(cte.DestYCoordinate - cte.DepartYCoordinate)))) AS DistanceTravelled
FROM SpaceFlight.Person AS p
    INNER JOIN SpaceFlight.FlightPerson AS fp ON fp.PersonID = p.PersonID
    INNER JOIN SpaceFlight.Flight AS f ON f.FlightID = fp.FlightID
    INNER JOIN cte ON cte.FlightID = f.FlightID
WHERE f.DepartureDateTime IS NOT NULL AND f.ArrivalDateTime IS NOT NULL
GROUP BY p.PersonID, p.FirstName, p.LastName, p.EmailAddress
ORDER BY DistanceTravelled DESC

-- EXEC SpaceFlight.RankPersonByDistanceTravelled