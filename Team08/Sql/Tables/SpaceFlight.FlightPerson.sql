CREATE TABLE SpaceFlight.FlightPerson
(
    FlightID INT NOT NULL FOREIGN KEY REFERENCES SpaceFlight.Flight(FlightID), 
    PersonID INT NOT NULL FOREIGN KEY REFERENCES SpaceFlight.Person(PersonID),

    PRIMARY KEY(FlightID, PersonID)
);