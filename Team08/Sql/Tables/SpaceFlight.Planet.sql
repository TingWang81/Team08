USE master
GO

-- DROP TABLE IF EXISTS SpaceFlight.Planet;

CREATE TABLE SpaceFlight.Planet
(
    PlanetID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    PlanetName NVARCHAR(64) NOT NULL UNIQUE,
    Mass DECIMAL NOT NULL,
    Radius DECIMAL NOT NULL,
    XCoordinate DECIMAL NOT NULL,
    YCoordinate DECIMAL NOT NULL,
    DistanceFromEarth DECIMAL NOT NULL,

    SolarSystemID INT NOT NULL FOREIGN KEY
        REFERENCES SpaceFlight.SolarSystem(SolarSystemID),

    UNIQUE
    (
        SolarSystemID ASC
    )
);