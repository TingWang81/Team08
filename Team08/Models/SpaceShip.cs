using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team08.Models
{
    public class SpaceShip
    {
        public int ShipID;
        public string ShipName;
        public int ShipTypeID;
        private int totalNumPassengers;

        public SpaceShip(int shipID, string shipName, int shipTypeID)
        {
            ShipID = shipID;
            ShipName = shipName;
            ShipTypeID = shipTypeID;
        }

        public int TotalNumPassengers { get => totalNumPassengers; set => totalNumPassengers = value; }
    }
}
