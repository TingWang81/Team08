using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team08.Models
{
    public class ShipType
    {
        public int ShipTypeID;
        public string Name;
        public int Capacity;

        private string shipName;

        public ShipType(int shipTypeID, string name, int capacity)
        {
            ShipTypeID = shipTypeID;
            Name = name;
            Capacity = capacity;
        }

        public string ShipName { get => shipName; set => shipName = value; }
    }
}
