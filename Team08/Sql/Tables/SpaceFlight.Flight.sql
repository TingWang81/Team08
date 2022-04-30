-- DROP TABLE SpaceFlight.Flight

CREATE TABLE SpaceFlight.Flight
(
    FlightID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    DepartureDateTime NVARCHAR(64) NOT NULL,
    ArrivalDateTime NVARCHAR(64) NOT NULL,
	TicketPrice INT NOT NULL,
    ShipID INT NOT NULL FOREIGN KEY REFERENCES SpaceFlight.SpaceShip(ShipID),
    DeparturePlanetID INT NOT NULL FOREIGN KEY REFERENCES SpaceFlight.Planet(PlanetID),
    DestinationPlanetID INT NOT NULL FOREIGN KEY REFERENCES SpaceFlight.Planet(PlanetID)
);

-- INSERT SpaceFlight.Flight(ShipID, DeparturePlanetID, DestinationPlanetID, DepartureDateTime, ArrivalDateTime, TicketPrice)
-- VALUES
-- (1,4,1,N'2023-01-01',N'2026-01-01', 1),
-- (2,3,6,N'2023-02-01',N'2025-02-04', 5790),
-- (3,4,7,N'2023-03-01',N'2025-03-02', 14432),
-- (4,5,8,N'2023-04-01',N'2023-08-07', 23583),
-- (5,6,1,N'2023-05-01',N'2024-05-23', 44234),
-- (6,7,4,N'2023-06-01',N'2024-07-13', 239),
-- (7,8,5,N'2023-07-01',N'2025-10-02', 54324),
-- (8,1,2,N'2023-08-01',N'2025-11-23', 23452),
-- (2,4,3,N'2023-09-01',N'2024-12-25', 18652),
-- (4,7,5,N'2023-10-01',N'2024-02-07', 28472),
-- (1,3,1,N'2023-11-01',N'2026-04-23', 29426),
-- (3,6,5,N'2023-12-01',N'2027-06-08', 599568);

-- SELECT *
-- FROM SpaceFlight.Flight