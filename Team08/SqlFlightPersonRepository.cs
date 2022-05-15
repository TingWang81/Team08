using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Team08.Models;

namespace Team08
{
    class SqlFlightPersonRepository : IFlightPersonRepository
    {
        private string connectionString;

        public SqlFlightPersonRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void DeleteFlightPerson(FlightPerson fp)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (var connection = new SqlConnection(this.connectionString))
                {
                    using (var command = new SqlCommand("SpaceFlight.DeleteFlightPerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("FlightID", fp.FlightID);
                        command.Parameters.AddWithValue("PersonID", fp.PersonID);

                        connection.Open();

                        command.ExecuteNonQuery();

                        scope.Complete();
                    }
                }
            }
        }

        /// <summary>
        /// Get all scheduled flights booked by given personID.
        /// </summary>
        /// <param name="personID"></param>
        /// <returns></returns>
        public List<FlightPerson> GetBookedFlightsGivenSpecifiedPerson(int personID)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                using (var command = new SqlCommand("SpaceFlight.GetBookedFlightsOfPerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("PersonID", personID);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslateFlightPersons(reader);
                }
            }
        }

        /// <summary>
        /// Gets flight person record based on flightID and personID.
        /// </summary>
        /// <param name="flightID"></param>
        /// <param name="personID"></param>
        /// <returns></returns>
        public FlightPerson GetFlightPerson(int flightID, int personID)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                using (var command = new SqlCommand("SpaceFlight.GetFlightPerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("FlightID", flightID);
                    command.Parameters.AddWithValue("PersonID", personID);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslateFlightPerson(reader);
                }
            }
        }

        /// <summary>
        /// Insert a flightperson to the database if it doesn't exist.
        /// </summary>
        /// <param name="fp"></param>
        public void InsertFlightPerson(FlightPerson fp)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (var connection = new SqlConnection(this.connectionString))
                {
                    using (var command = new SqlCommand("SpaceFlight.InsertFlightPerson", connection))
                    {
                        if (GetFlightPerson(fp.FlightID, fp.PersonID) == null)
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("FlightID", fp.FlightID);
                            command.Parameters.AddWithValue("PersonID", fp.PersonID);

                            connection.Open();

                            command.ExecuteNonQuery();

                            scope.Complete();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Converts sql datareader into flightperson object.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private FlightPerson TranslateFlightPerson(SqlDataReader reader)
        {
            var flightIDOrdinal = reader.GetOrdinal("FlightID");
            var personIDOrdinal = reader.GetOrdinal("PersonID");

            if (!reader.Read())
                return null;

            return new FlightPerson(
               reader.GetInt32(flightIDOrdinal),
               reader.GetInt32(personIDOrdinal));
        }

        /// <summary>
        /// Converts sql datareader into list of flightperson objects.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private List<FlightPerson> TranslateFlightPersons(SqlDataReader reader)
        {
            var flightIDOrdinal = reader.GetOrdinal("FlightID");
            var personIDOrdinal = reader.GetOrdinal("PersonID");

            List<FlightPerson> flightPersons = new List<FlightPerson>();

            while (reader.Read())
            {
               flightPersons.Add(new FlightPerson(
               reader.GetInt32(flightIDOrdinal),
               reader.GetInt32(personIDOrdinal)));
            }

            return flightPersons;
        }
    }
}
