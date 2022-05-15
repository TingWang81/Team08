CREATE OR ALTER PROCEDURE SpaceFlight.GetShipTypeByShipID(@ShipID INT)
AS
SELECT ss.ShipID, ss.ShipName, st.Name
FROM SpaceFlight.ShipType AS st 
    INNER JOIN SpaceFlight.SpaceShip AS ss ON ss.ShipTypeID = st.ShipTypeID
WHERE ss.ShipID = @ShipID