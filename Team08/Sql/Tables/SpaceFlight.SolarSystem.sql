CREATE TABLE SpaceFlight.SolarSystem
(

    SolarSystemID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    SolarSystemName NVARCHAR(64) NOT NULL UNIQUE,
    
);