CREATE OR ALTER PROCEDURE SpaceFlight.GetPlanet(@PlanetName NVARCHAR(64))
AS
SELECT Pl.PlanetID, Pl.PlanetName, Pl.Mass, Pl.Radius, Pl.eclipticCoordinatee, Pl.DistanceFromEarth, Pl.SolarSystemID
FROM SpaceFlight.Planet Pl
WHERE Pl.planetName = @PlanetName;
GO