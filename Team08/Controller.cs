﻿using System;
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

        public Controller()
        {
            this.connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;";
            this.personRepo = new SqlPersonRepository(this.connectionString);
        }

        public Person GetPerson(string lastName, string firstName)
        {
            return this.personRepo.GetPerson(lastName, firstName);
        }

        //public List<Person> RankPersonsByDistance()
        //{

        //}
    }
}
