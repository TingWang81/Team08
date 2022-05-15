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
        private string connectionString;
        private IPersonRepository personRepo;
        private IPlanetRepository planetRepo;
        private IShipRepository spaceshipRepo;
        private IFlightRepository flightRepo;
        private IFlightPersonRepository flightPersonRepo;
        private IShipTypeRepository shipTypeRepo;

        public Controller()
        {
            this.connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;";

            this.personRepo = new SqlPersonRepository(this.connectionString);
            this.spaceshipRepo = new SqlShipRepository(this.connectionString);
            this.planetRepo = new SqlPlanetRepository(this.connectionString);
            this.flightRepo = new SqlFlightRepository(this.connectionString);
            this.flightPersonRepo = new SqlFlightPersonRepository(this.connectionString);
            this.shipTypeRepo = new SqlShipTypeRepository(this.connectionString);
        }

        public ShipType GetShipTypeByShipID(int shipID)
        {
            return this.shipTypeRepo.GetShipTypeByShipID(shipID);
        }

        /// <summary>
        /// Gets a person given lastname and firstname from database.
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public Person GetPerson(string lastName, string firstName)
        {
            return this.personRepo.GetPerson(lastName, firstName);
        }

        /// <summary>
        /// Gets all planets from the database.
        /// </summary>
        /// <returns></returns>
        public List<Planet> GetListOfPlanets()
        {
            return this.planetRepo.GetAllPlanets();
        }

        /// <summary>
        /// Gets list of schedudled flights to a unique planet. Only scheduled flights (without arrival time) should be included.
        /// </summary>
        /// <param name="solarSystemName"></param>
        /// <param name="planetName"></param>
        /// <returns></returns>
        public List<Flight> GetScheduledFlightsToPlanet(string solarSystemName, string planetName)
        {
            return this.flightRepo.GetScheduledFlightsToPlanet(solarSystemName, planetName, 14);
        }

        /// <summary>
        /// Queries database for persons and executes stored procedure to rank them according to the distance they travelled.
        /// </summary>
        /// <returns></returns>
        public List<Person> RankPersonsByDistance()
        {
            return this.personRepo.RankPersonByDistanceTravelled();
        }

        /// <summary>
        /// Queries database for spaceships and ranks spaceships in use by total number of passengers to date.
        /// </summary>
        /// <returns></returns>
        public List<SpaceShip>RankShipsByTotalNumPassengers()
        {
            return this.spaceshipRepo.RankShipByTotalPassengers();
        }

        /// <summary>
        /// Updates a FlightPerson record in the database and Inserts new Person row if necessary.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        public void BookFlight(string firstName, string lastName, string email, Flight f)
        {
            this.personRepo.InsertPersonIfNonExistent(new Person(0, firstName, lastName, email));
            Person p = this.personRepo.GetPerson(lastName, firstName);

            FlightPerson fp = new FlightPerson(f.FlightID, p.PersonID);
            this.flightPersonRepo.InsertFlightPerson(fp);
        }

        public List<FlightPerson> GetBookedFlightsFromPerson(int personID)
        {
            return this.flightPersonRepo.GetBookedFlightsGivenSpecifiedPerson(personID);
        }

        public void UpdatePerson(Person p)
        {
            this.personRepo.UpdatePerson(p);
        }

        /// <summary>
        /// Trys to delete the booked flight of a given person by removing the corrosponding row in database.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="f"></param>
        public void DeleteFlightPerson(string firstName, string lastName, string email, Flight f)
        {
            Person p = new Person(0, firstName, lastName, email);
            this.personRepo.InsertPersonIfNonExistent(p);
            p = this.personRepo.GetPerson(p.LastName, p.FirstName);

            FlightPerson fp = new FlightPerson(f.FlightID, p.PersonID);

            this.flightPersonRepo.DeleteFlightPerson(fp);
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
