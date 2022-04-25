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
    public class SqlPlanetRepository : IPlanetRepository
    {
        private readonly string connectionString;

        public SqlPlanetRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Planet GetPlanet(string name)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("SpaceFlight.GetPlanet", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("PlanetName", name);
                    //command.Parameters.AddWithValue("FirstName", firstName);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslatePlanet(reader);
                }
            }
        }

        private Planet TranslatePlanet(SqlDataReader reader)
        {
            var planetIdOrdinal = reader.GetOrdinal("PlanetID");
            var planetnameOrdinal = reader.GetOrdinal("PlanetName");
            var planetmass = reader.GetOrdinal("Mass");
            var planetradius = reader.GetOrdinal("Radius");
            var planetEcli = reader.GetOrdinal("eclipticCoordinatee");
            var planetdis = reader.GetOrdinal("DistanceFromEarth");
            var planetSolo = reader.GetOrdinal("SolarSystemID");
  

            if (!reader.Read())
                return null;

            return new Planet(
               reader.GetInt32(planetIdOrdinal),
               reader.GetString(planetnameOrdinal),
               reader.GetDecimal(planetmass),
               reader.GetDecimal(planetradius),
               reader.GetDecimal(planetEcli),
               reader.GetDecimal(planetdis),
               reader.GetInt32(planetSolo));

            //reader.GetString(emailOrdinal));
        }
    }
}
