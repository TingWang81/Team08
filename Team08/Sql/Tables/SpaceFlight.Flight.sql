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