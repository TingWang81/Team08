-- DROP TABLE SpaceFlight.FlightPerson

CREATE TABLE SpaceFlight.FlightPerson
(
    FlightID INT NOT NULL FOREIGN KEY REFERENCES SpaceFlight.Flight(FlightID), 
    PersonID INT NOT NULL FOREIGN KEY REFERENCES SpaceFlight.Person(PersonID),

    PRIMARY KEY(FlightID, PersonID)
);

-- INSERT SpaceFlight.FlightPerson(FlightID, PersonID)
-- VALUES 
--     (1, 11),
--     (1, 2),
--     (2, 3)