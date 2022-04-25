USE master
GO

CREATE TABLE SpaceObject.SpaceShip
(
    ShipID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    ShipName NVARCHAR(64) NOT NULL UNIQUE,
    ShipTypeID INT NOT NULL FOREIGN KEY
        REFERENCES SpaceObject.ShipType(ShipTypeID),
);