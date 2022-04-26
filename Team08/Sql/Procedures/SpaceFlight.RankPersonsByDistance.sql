CREATE OR ALTER PROCEDURE SpaceFlight.RankPersonsByDistance()

SELECT *
FROM SpaceFlight.Planet

SELECT P.PersonId, P.FirstName, P.LastName, P.EmailAddress
FROM SpaceFlight.Person P 
    INNER JOIN SpaceFlight.FlightPerson FP ON FP.PersonID = P.PersonID
    INNER JOIN SpaceFlight.Flight F ON F.FlightID = FP.FlightID
