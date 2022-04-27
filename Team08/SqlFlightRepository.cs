using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team08.Models;

namespace Team08
{
    class SqlFlightRepository : IFlightRepository
    {
        private string connectionString;

        public SqlFlightRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Gets a scheduled flight with specified destination planet.
        /// </summary>
        /// <param name="solarSystemName"></param>
        /// <param name="planetName"></param>
        /// <returns></returns>
        public List<Flight> GetScheduledFlightsToPlanet(string solarSystemName, string destinationPlanetName, int departureID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("SpaceFlight.GetScheduledFlights", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("SolarSystemName", solarSystemName);
                    command.Parameters.AddWithValue("DestinationPlanetName", destinationPlanetName);
                    command.Parameters.AddWithValue("DeparturePlanetID", departureID);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslateFlights(reader);
                }
            }
        }

        /// <summary>
        /// Converts sql reader to list of Flight objects.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private List<Flight> TranslateFlights(SqlDataReader reader)
        {
            var flightIDOrdinal = reader.GetOrdinal("FlightID");
            var departureDateTimeOrdinal = reader.GetOrdinal("DepartureDateTime");
            var arrivalDateTimeOrdinal = reader.GetOrdinal("ArrivalDateTime");
            var ticketPriceOrdinal = reader.GetOrdinal("TicketPrice");
            var shipIDOrdinal = reader.GetOrdinal("ShipID");
            var departurePlanetIDOrdinal = reader.GetOrdinal("DeparturePlanetID");
            var destinationPlanetIDOrdinal = reader.GetOrdinal("DestinationPlanetID");
            var destinationPlanetNameOrdinal = reader.GetOrdinal("DestinationPlanet");

            List<Flight> scheduledFlights = new List<Flight>();

            while (reader.Read())
            {
                Flight f = new Flight(
                    reader.GetInt32(flightIDOrdinal),
                    reader.GetInt32(shipIDOrdinal),
                    reader.GetInt32(departurePlanetIDOrdinal),
                    reader.GetInt32(destinationPlanetIDOrdinal),
                    reader.GetString(departureDateTimeOrdinal),
                    null,
                    reader.GetInt32(ticketPriceOrdinal),
                    reader.GetString(destinationPlanetNameOrdinal)
                    );

                scheduledFlights.Add(f);
            }

            return scheduledFlights;
        }
    }
}
