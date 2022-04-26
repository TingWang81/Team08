using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team08.Models;

namespace Team08
{
    public interface IPlanetRepository
    {

        List<Planet> GetAllPlanets();

        Planet GetPlanet(string name);

    }
}
