using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team08.Models
{
    class SolarSystem
    {
        public int SolarSystemID;
        public string SolarSystemName;

        public SolarSystem(int solarSystemID, string solarSystemName)
        {
            SolarSystemID = solarSystemID;
            SolarSystemName = solarSystemName;
        }
    }
}
