-- DROP TABLE IF EXISTS SpaceFlight.Planet;

CREATE TABLE SpaceFlight.Planet
(
    PlanetID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    PlanetName NVARCHAR(64) NOT NULL UNIQUE,
<<<<<<< HEAD
    Mass FLOAT NOT NULL,
    Radius FLOAT NOT NULL,
    XCoordinate FLOAT NOT NULL,
    YCoordinate FLOAT NOT NULL,
    DistanceFromEarth FLOAT NOT NULL,

    SolarSystemID INT NOT NULL FOREIGN KEY
        REFERENCES SpaceFlight.SolarSystem(SolarSystemID),  
);

-- INSERT SpaceFlight.Planet(SolarSystemID, PlanetName, Mass, Radius, XCoordinate, YCoordinate, DistanceFromEarth)--, XCoordinate, YCoordinate, DistanceFromEarth)
-- VALUES
-- (3, N'Sun', 198850.00, 432690.00, 12.0322, 15.0, 93.263),
-- (3, N'Mercury', 3.29, 1516.00, 2.585, -18.0, 109.36),
-- (3, N'Venus', 48.67, 3760.4, 8.4, 10.0, 82.033),
-- (3, N'Earth', 59.72, 3958.8, 0.0, 0.0, 0),
-- (3, N'Mars', 6.39, 2106.1, 12.55, 1.0, 106.35),
-- (3, N'Jupiter', 18980.00, 43.441, 3.13, -14.8, 539.87),
-- (3, N'Saturn', 5683.00, 36184.00, 14.48, -14.48, 958.19),
-- (3, N'Uranus', 868.1, 15759.00, 15.29, -12.34, 1991.9),
-- (3, N'Neptune', 1024.00, 15299.00, 3.3, 25.89, 2859.3);