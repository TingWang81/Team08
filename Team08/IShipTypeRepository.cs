using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team08.Models;

namespace Team08
{
    interface IShipTypeRepository
    {
        ShipType GetShipTypeByShipID(int shipID);
    }
}
