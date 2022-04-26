using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team08.Models
{
    public class Planet
    {
        public int PlanetID;
        public string PlanetName;
        public decimal Mass;
        public decimal Radius;
        public decimal XCoordinate;
        public decimal YCoordinate;
        public decimal DistanceFromEarth;
        public int SolarSystemID;

        public Planet(int planetID, string planetName, decimal mass, decimal radius, decimal xCoordinate, decimal yCoordinate, decimal distanceFromEarth, int solarSystemID)
        {
            PlanetID = planetID;
            PlanetName = planetName;
            Mass = mass;
            Radius = radius;
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            DistanceFromEarth = distanceFromEarth;
            SolarSystemID = solarSystemID;
        }
    }
}
