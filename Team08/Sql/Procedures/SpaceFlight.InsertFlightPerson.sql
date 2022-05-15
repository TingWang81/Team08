CREATE OR ALTER PROCEDURE SpaceFlight.InsertFlightPerson(@FlightID INT, @PersonID INT)
AS
INSERT SpaceFlight.FlightPerson(FlightID, PersonID)
VALUES
    (@FlightID, @PersonID)