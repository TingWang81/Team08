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
    public class SqlShipTypeRepository : IShipTypeRepository
    {
        private string connectionString;

        public SqlShipTypeRepository(string stringConnection)
        {
            this.connectionString = stringConnection;
        }

        /// <summary>
        /// Queries database for coorsponding shiptype entry based on shipID.
        /// </summary>
        /// <param name="shipID"></param>
        /// <returns></returns>
        public ShipType GetShipTypeByShipID(int shipID)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                using (var command = new SqlCommand("SpaceFlight.GetShipTypeByShipID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("ShipID", shipID);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TanslateShipType(reader);
                }
            }
        }

        private ShipType TanslateShipType(SqlDataReader reader)
        {
            var nameOrdinal = reader.GetOrdinal("Name");
            var capacityOrdinal = reader.GetOrdinal("ShipName");

            if (!reader.Read())
                return null;

            ShipType st =  new ShipType(0, reader.GetString(nameOrdinal), 0);

            st.ShipName = reader.GetString(capacityOrdinal);

            return st;
        }
    }
}
