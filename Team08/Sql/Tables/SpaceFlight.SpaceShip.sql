<<<<<<< HEAD
CREATE TABLE SpaceFlight.SpaceShip
=======
﻿USE master
GO

CREATE TABLE SpaceObject.SpaceShip
>>>>>>> 8be9f027d5fef8841cc3493d90aaf69e0c2d7fc6
(
    ShipID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    ShipName NVARCHAR(64) NOT NULL UNIQUE,
    ShipTypeID INT NOT NULL FOREIGN KEY
<<<<<<< HEAD
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
=======
        REFERENCES SpaceObject.ShipType(ShipTypeID),
);
>>>>>>> 8be9f027d5fef8841cc3493d90aaf69e0c2d7fc6
