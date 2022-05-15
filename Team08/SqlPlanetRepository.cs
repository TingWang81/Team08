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

        /// <summary>
        /// Gets all planets in database.
        /// </summary>
        /// <returns></returns>
        public List<Planet> GetAllPlanets()
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                using (var command = new SqlCommand("SpaceFlight.GetAllPlanets", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslatePlanets(reader);
                }
            }
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

        /// <summary>
        /// Converts SqlDataReader to one Planet object.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private Planet TranslatePlanet(SqlDataReader reader)
        {
            var planetIDOrdinal = reader.GetOrdinal("PlanetID");
            var PlanetNameOrdinal = reader.GetOrdinal("PlanetName");
            var MassOrdinal = reader.GetOrdinal("Mass");
            var RadiusOrdinal = reader.GetOrdinal("Radius");
            var XCoordinateOrdinal = reader.GetOrdinal("XCoordinate");
            var YCoordinateOrdinal = reader.GetOrdinal("YCoordinate");
            var SolarSystemIDOrdinal = reader.GetOrdinal("SolarSystemID");

            if (!reader.Read())
                return null;

            return new Planet(
               reader.GetInt32(planetIDOrdinal),
               reader.GetString(PlanetNameOrdinal),
               reader.GetDecimal(MassOrdinal),
               reader.GetDecimal(RadiusOrdinal),
               reader.GetDecimal(XCoordinateOrdinal),
               reader.GetDecimal(YCoordinateOrdinal),
               reader.GetInt32(SolarSystemIDOrdinal)) ;
        }

        /// <summary>
        /// Converts multiple reader into multiple planet objects.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private List<Planet> TranslatePlanets(SqlDataReader reader)
        {
            List<Planet> planets = new List<Planet>();

            var planetIDOrdinal = reader.GetOrdinal("PlanetID");
            var PlanetNameOrdinal = reader.GetOrdinal("PlanetName");
            var MassOrdinal = reader.GetOrdinal("Mass");
            var RadiusOrdinal = reader.GetOrdinal("Radius");
            var XCoordinateOrdinal = reader.GetOrdinal("XCoordinate");
            var YCoordinateOrdinal = reader.GetOrdinal("YCoordinate");
            var SolarSystemIDOrdinal = reader.GetOrdinal("SolarSystemID");

            if (!reader.Read())
                return null;

            while (reader.Read())
            {
               Planet p = new Planet(
               reader.GetInt32(planetIDOrdinal),
               reader.GetString(PlanetNameOrdinal),
               reader.GetDecimal(MassOrdinal),
               reader.GetDecimal(RadiusOrdinal),
               reader.GetDecimal(XCoordinateOrdinal),
               reader.GetDecimal(YCoordinateOrdinal),
               reader.GetInt32(SolarSystemIDOrdinal));

               planets.Add(p);
            }

            return planets;
        }
    }
}
