using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team08.Models;

namespace Team08
{
    public class Controller
    {
        string connectionString;
        IPersonRepository personRepo;
        IShipRepository spaceshipRepo;
        IPlanetRepository planetRepo;
        public Controller()
        {
            this.connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=master;";
            this.personRepo = new SqlPersonRepository(this.connectionString);
            this.spaceshipRepo = new SqlShipRepository(this.connectionString);
            this.planetRepo = new SqlPlanetRepository(this.connectionString);
        }

        public Person GetPerson(string lastName, string firstName)
        {
            return this.personRepo.GetPerson(lastName, firstName);
        }

        public SpaceShip GetSpaceShip(string name)
        {
            return this.spaceshipRepo.GetSpaceShip(name);
        }
        public Planet GetPlanet(string name)
        {
            return this.planetRepo.GetPlanet(name);
        }
    }
}
