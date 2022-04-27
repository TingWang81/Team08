CREATE OR ALTER PROCEDURE GetScheduledFlights(@SolarSystemName NVARCHAR(64), @DestinationPlanetName NVARCHAR(64), @DeparturePlanetID INT)
AS

SELECT F.FlightID, F.DepartureDateTime, F.ArrivalDateTime, F.DeparturePlanetID, F.DestinationPlanetID, P.PlanetID, P.PlanetName
FROM SpaceFlight.Flight AS F 
    INNER JOIN SpaceFlight.Planet AS P ON P.PlanetID = F.DestinationPlanetID
WHERE F.ArrivalDateTime IS NULL AND F.DeparturePlanetID = @DeparturePlanetID AND P.PlanetName = @DestinationPlanetName