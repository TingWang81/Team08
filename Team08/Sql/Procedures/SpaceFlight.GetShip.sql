CREATE OR ALTER PROCEDURE SpaceFlight.GetShip(@ShipName NVARCHAR(64))
AS
SELECT P.PersonId, S.ShipName
FROM SpaceFlight.SpaceShip S
WHERE S.ShipName = @ShipName;
GO