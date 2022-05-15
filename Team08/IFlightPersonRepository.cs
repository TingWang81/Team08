using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team08.Models;

namespace Team08
{
    interface IFlightPersonRepository
    {
        void InsertFlightPerson(FlightPerson fp);

        void DeleteFlightPerson(FlightPerson fp);

        FlightPerson GetFlightPerson(int flightID, int personID);

        List<FlightPerson> GetBookedFlightsGivenSpecifiedPerson(int personID);
    }
}
