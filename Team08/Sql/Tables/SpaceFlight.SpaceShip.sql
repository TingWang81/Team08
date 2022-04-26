CREATE TABLE SpaceObject.SpaceShip
(
    ShipID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    ShipName NVARCHAR(64) NOT NULL UNIQUE,
    ShipTypeID INT NOT NULL FOREIGN KEY
        REFERENCES SpaceFlight.ShipType(ShipTypeID),
);

-- INSERT SpaceFlight.SpaceShip(ShipTypeID, ShipName)
-- VALUES
-- (1, N'BC'),
-- (2, N'BS'),
-- (3, N'CS'),
-- (4, N'HMS'),
-- (5, N'HWSS'),
-- (6, N'ISS'),
-- (7, N'LWSS'),
-- (8, N'SC');

-- SELECT *
-- FROM SpaceFlight.SpaceShip
