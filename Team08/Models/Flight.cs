using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team08.Models
{
    public class Flight
    {
        public int FlightID;
        public int ShipID;
        public int DeparturePlanetID;
        public int DestinationPlanetID;
        public DateTime DepartureDateTime;
        public DateTime ArraivalDateTime;
        public Double TicketPrice;

        public Flight(int flightID, int shipID, int departurePlanetID, int destinationPlanetID, DateTime departureDateTime, DateTime arraivalDateTime, double ticketPrice)
        {
            FlightID = flightID;
            ShipID = shipID;
            DeparturePlanetID = departurePlanetID;
            DestinationPlanetID = destinationPlanetID;
            DepartureDateTime = departureDateTime;
            ArraivalDateTime = arraivalDateTime;
            TicketPrice = ticketPrice;
        }
    }
}
