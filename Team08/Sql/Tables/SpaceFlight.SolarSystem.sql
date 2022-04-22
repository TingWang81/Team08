CREATE TABLE SpaceFlight.SolarSystem
(

    SolarSystemID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    SolarSystemName NVARCHAR(64) NOT NULL UNIQUE,
    
);

-- INSERT SpaceFlight.SolarSystem(SolarSystemName)
-- VALUES 
--     (N'System456'),
--     (N'System123'),
--     (N'The Solar System')

-- SELECT * 
-- FROM SpaceFlight.SolarSystem