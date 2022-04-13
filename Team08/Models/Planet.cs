using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team08.Models
{
    class Planet
    {
        public int PlanetID;
        public int SolarSystemID;
        public string PlanetName;
        public Double Mass;
        public Double Radius;
        public Double XCoordinate;
        public Double YCoordinate;
        public Double DistanceFromEarth;

        public Planet(int planetID, int solarSystemID, string planetName, double mass, double radius, double xCoordinate, double yCoordinate, double distanceFromEarth)
        {
            PlanetID = planetID;
            SolarSystemID = solarSystemID;
            PlanetName = planetName;
            Mass = mass;
            Radius = radius;
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            DistanceFromEarth = distanceFromEarth;
        }
    }
}
