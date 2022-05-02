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
    public class SqlShipRepository : IShipRepository
    {
        private readonly string connectionString;

        public SqlShipRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public SpaceShip GetSpaceShip(string name)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("SpaceFlight.GetSpaceShip", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("ShipName", name);
                    //command.Parameters.AddWithValue("FirstName", firstName);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslateSpaceShip(reader);
                }
            }
        }

        /// <summary>
        /// Returns ranked spaceships by total number of passengers carried up to date.
        /// </summary>
        /// <returns></returns>
        public List<SpaceShip> RankShipByTotalPassengers()
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                using (var command = new SqlCommand("SpaceFlight.RankShipByTotalNumPassengers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslateSpaceShipsByTotalPassengers(reader);
                }
            }
        }

        private SpaceShip TranslateSpaceShip(SqlDataReader reader)
        {
            var shipIdOrdinal = reader.GetOrdinal("ShipID");
            var shipnameOrdinal = reader.GetOrdinal("ShipName");
            var shiptypeid = reader.GetOrdinal("ShipTypeID");
            //var emailOrdinal = reader.GetOrdinal("EmailAddress");

            if (!reader.Read())
                return null;

            return new SpaceShip(
               reader.GetInt32(shipIdOrdinal),
               reader.GetString(shipnameOrdinal),
               reader.GetInt32(shiptypeid));
               //reader.GetString(emailOrdinal));
        }

        /// <summary>
        /// Converts sql reader to list of spaceships while updating the spaceships total number of passengers to date.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private List<SpaceShip> TranslateSpaceShipsByTotalPassengers(SqlDataReader reader)
        {
            var shipIdOrdinal = reader.GetOrdinal("ShipID");
            var shipnameOrdinal = reader.GetOrdinal("ShipName");
            var shiptypeidOrdinal = reader.GetOrdinal("ShipTypeID");
            var totalPassOrdinal = reader.GetOrdinal("NumPassengers");

            List<SpaceShip> spaceShips = new List<SpaceShip>();

            while (reader.Read())
            {
                SpaceShip ss = new SpaceShip(reader.GetInt32(shipIdOrdinal), reader.GetString(shipnameOrdinal), reader.GetInt32(shiptypeidOrdinal));

                ss.TotalNumPassengers = reader.GetInt32(totalPassOrdinal);

                spaceShips.Add(ss);
            }

            return spaceShips;
        }
    }
}
