CREATE OR ALTER PROCEDURE SpaceFlight.GetScheduledFlights(@SolarSystemName NVARCHAR(64), @DestinationPlanetName NVARCHAR(64), @DeparturePlanetID INT)
AS

SELECT F.FlightID, F.TicketPrice, F.ShipID, F.DepartureDateTime, F.ArrivalDateTime, F.DeparturePlanetID, F.DestinationPlanetID, P.PlanetName AS DestinationPlanet
FROM SpaceFlight.Flight AS F 
    INNER JOIN SpaceFlight.Planet AS P ON P.PlanetID = F.DestinationPlanetID
WHERE F.ArrivalDateTime IS NULL AND F.DeparturePlanetID = @DeparturePlanetID AND P.PlanetName = @DestinationPlanetName