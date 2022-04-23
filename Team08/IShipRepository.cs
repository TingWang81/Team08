using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team08.Models;

namespace Team08
{
    public interface IShipRepository
    {

        SpaceShip GetSpaceShip(string name);
    }
}
