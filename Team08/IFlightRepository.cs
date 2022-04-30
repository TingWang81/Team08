using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team08.Models;

namespace Team08
{
    interface IFlightRepository
    {
        /// <summary>
        /// Gets list of schedudled flights to a unique planet. Only scheduled flights (without arrival time) should be included.
        /// </summary>
        /// <param name="solarSystemName"></param>
        /// <param name="planetName"></param>
        /// <returns></returns>
        List<Flight> GetScheduledFlightsToPlanet(string solarSystemName, string planetName, int departurePlanetID);

        /// <summary>
        /// Inserts a new row in the flight table.
        /// </summary>
        /// <param name="f"></param>
        void CreateFlight(Flight f);
    }
}
