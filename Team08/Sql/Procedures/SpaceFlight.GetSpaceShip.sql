CREATE OR ALTER PROCEDURE SpaceFlight.GetSpaceShip(@ShipName NVARCHAR(64))
AS
SELECT S.ShipID, S.ShipName, S.ShipTypeID
FROM SpaceFlight.SpaceShip S
WHERE S.ShipName = @ShipName;
GO