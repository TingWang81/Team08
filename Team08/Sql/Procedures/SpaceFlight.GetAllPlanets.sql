CREATE OR ALTER PROCEDURE SpaceFlight.GetAllPlanets
AS 

SELECT P.PlanetID, P.PlanetName, P.Mass, P.Radius, P.XCoordinate, P.YCoordinate, P.DistanceFromEarth, P.SolarSystemID
FROM SpaceFlight.Planet AS P