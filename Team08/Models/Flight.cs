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
        public DateTime ArrivalDateTime;
        public double TicketPrice;
        public string DestinationPlanetName;

        public Flight(int flightID, int shipID, int departurePlanetID, int destinationPlanetID, string departureDateTime, string arrivalDateTime, int ticketPrice, string destinationPlanetName)
        {
            FlightID = flightID;
            ShipID = shipID;
            DeparturePlanetID = departurePlanetID;
            DestinationPlanetID = destinationPlanetID;
            TicketPrice = ticketPrice;
            DestinationPlanetName = destinationPlanetName;

            if(departureDateTime != null)
            {
                DepartureDateTime = DateTime.Parse(departureDateTime);
            }
            
            if(arrivalDateTime != null)
            {
                ArrivalDateTime = DateTime.Parse(arrivalDateTime);
            }
        }
    }
}
