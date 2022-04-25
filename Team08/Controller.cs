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
        IPlanetRepository planetRepo;

        public Controller()
        {
            this.connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;";
            this.personRepo = new SqlPersonRepository(this.connectionString);
            this.planetRepo = new SqlPlanetRepository(this.connectionString);
        }

        public Person GetPerson(string lastName, string firstName)
        {
            return this.personRepo.GetPerson(lastName, firstName);
        }

        public List<Planet> GetListOfPlanets()
        {
            return this.planetRepo.GetAllPlanets();
        }

        //public List<Person> RankPersonsByDistance()
        //{

        //}
    }
}
