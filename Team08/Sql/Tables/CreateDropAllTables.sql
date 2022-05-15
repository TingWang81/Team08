-- Drop Table and Data
DROP TABLE IF EXISTS SpaceFlight.FlightPerson
DROP TABLE IF EXISTS SpaceFlight.Flight
DROP TABLE IF EXISTS SpaceFlight.Person
DROP TABLE IF EXISTS SpaceFlight.Planet
DROP TABLE IF EXISTS SpaceFlight.SolarSystem
DROP TABLE IF EXISTS SpaceFlight.SpaceShip
DROP TABLE IF EXISTS SpaceFlight.ShipType

CREATE TABLE SpaceFlight.Person
(

    PersonID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    FirstName NVARCHAR(64) NOT NULL,
    LastName NVARCHAR(64) NOT NULL,
	EmailAddress NVARCHAR(128) NOT NULL,
    
    UNIQUE(EmailAddress),
);

CREATE TABLE SpaceFlight.SolarSystem
(

    SolarSystemID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    SolarSystemName NVARCHAR(64) NOT NULL UNIQUE,
    
);

CREATE TABLE SpaceFlight.ShipType
(
    ShipTypeID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    [Name] NVARCHAR(64) NOT NULL UNIQUE,
    Capacity INT NOT NULL,
);

CREATE TABLE SpaceFlight.SpaceShip
(
    ShipID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    ShipName NVARCHAR(64) NOT NULL UNIQUE,
    ShipTypeID INT NOT NULL FOREIGN KEY
        REFERENCES SpaceFlight.ShipType(ShipTypeID),
);

CREATE TABLE SpaceFlight.Planet
(
    PlanetID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    PlanetName NVARCHAR(64) NOT NULL UNIQUE,
    Mass Decimal NOT NULL,
    Radius Decimal NOT NULL,
    XCoordinate Decimal NOT NULL,
    YCoordinate Decimal NOT NULL,

    SolarSystemID INT NOT NULL FOREIGN KEY
        REFERENCES SpaceFlight.SolarSystem(SolarSystemID),  
);

CREATE TABLE SpaceFlight.Flight
(
    FlightID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    DepartureDateTime NVARCHAR(64),
    ArrivalDateTime NVARCHAR(64),
	TicketPrice INT NOT NULL,
    ShipID INT NOT NULL FOREIGN KEY REFERENCES SpaceFlight.SpaceShip(ShipID),
    DeparturePlanetID INT NOT NULL FOREIGN KEY REFERENCES SpaceFlight.Planet(PlanetID),
    DestinationPlanetID INT NOT NULL FOREIGN KEY REFERENCES SpaceFlight.Planet(PlanetID)
);

CREATE TABLE SpaceFlight.FlightPerson
(
    FlightID INT NOT NULL FOREIGN KEY REFERENCES SpaceFlight.Flight(FlightID), 
    PersonID INT NOT NULL FOREIGN KEY REFERENCES SpaceFlight.Person(PersonID),

    PRIMARY KEY(FlightID, PersonID)
);