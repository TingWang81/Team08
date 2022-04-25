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
    }
}
