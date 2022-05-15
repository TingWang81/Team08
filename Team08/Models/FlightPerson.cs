using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team08.Models
{
    public class FlightPerson
    {
        public int FlightID;
        public int PersonID;

        public FlightPerson(int flightID, int personID)
        {
            FlightID = flightID;
            PersonID = personID;
        }
    }
}
