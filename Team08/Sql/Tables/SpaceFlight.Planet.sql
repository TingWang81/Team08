CREATE TABLE SpaceFlight.Planet
(
    PlanetID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    PlanetName NVARCHAR(64) NOT NULL UNIQUE,
    Mass Decimal NOT NULL,
    Radius Decimal NOT NULL,
    XCoordinate Decimal NOT NULL,
    YCoordinate Decimal NOT NULL,
    DistanceFromEarth Decimal NOT NULL,

    SolarSystemID INT NOT NULL FOREIGN KEY
        REFERENCES SpaceFlight.SolarSystem(SolarSystemID),  
);