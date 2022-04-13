using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team08.Models
{
    class FlightSchedule
    {
        public int FlightScheduleID;
        public int FlightID;
        public DateTime DepartureDateTime;

        public FlightSchedule(int flightScheduleID, int flightID, DateTime departureDateTime)
        {
            FlightScheduleID = flightScheduleID;
            FlightID = flightID;
            DepartureDateTime = departureDateTime;
        }
    }
}
