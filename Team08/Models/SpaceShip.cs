using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team08.Models
{
    class SpaceShip
    {
        public int ShipID;
        public string ShipName;
        public int ShipTypeID;

        public SpaceShip(int shipID, string shipName, int shipTypeID)
        {
            ShipID = shipID;
            ShipName = shipName;
            ShipTypeID = shipTypeID;
        }
    }
}
