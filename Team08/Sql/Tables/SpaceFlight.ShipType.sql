CREATE TABLE SpaceFlight.ShipType
(
    ShipTypeID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    [Name] NVARCHAR(64) NOT NULL UNIQUE,
    Capacity INT NOT NULL,
);

-- INSERT SpaceFlight.ShipType([Name], Capacity)
-- VALUES
-- (N'Battlecruiser', 25658),
-- (N'Battleship', 23996),
-- (N'Cargo ship', 43996),
-- (N'Her Majesty Ship', 50278),
-- (N'Heavy Weight Spaceship', 93289),
-- (N'Imperial Spaceship', 43570),
-- (N'Light Weight Spaceship', 69740),
-- (N'Spacecruiser', 23335);

-- SELECT *
-- FROM SpaceFlight.ShipType