﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Team08.Models;

namespace Team08
{
    public class SqlPersonRepository : IPersonRepository
    {
        private readonly string connectionString;

        public SqlPersonRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Querries Person table from database to find person with first and last name.
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public Person GetPerson(string lastName, string firstName)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("SpaceFlight.GetPerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("LastName", lastName);
                    command.Parameters.AddWithValue("FirstName", firstName);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslatePerson(reader);
                }
            }
        }

        /// <summary>
        /// Inserts new person row into database unless that person exists.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        public void InsertPersonIfNonExistent(Person p)
        {
            // Save to database.
            using (TransactionScope scope = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("SpaceFlight.InsertPerson", connection))
                    {

                        if(GetPerson(p.LastName, p.FirstName) == null)
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("FirstName", p.FirstName);
                            command.Parameters.AddWithValue("LastName", p.LastName);
                            command.Parameters.AddWithValue("Email", p.EmailAddress);

                            //var fl = command.Parameters.Add("PersonID", SqlDbType.Int);
                            //fl.Direction = ParameterDirection.Output;

                            connection.Open();

                            command.ExecuteNonQuery();

                            scope.Complete();
                        }
                    }
                }
            }
        }

        public void UpdatePerson(Person p)
        {
            // Save to database.
            using (TransactionScope scope = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("SpaceFlight.UpdatePerson", connection))
                    {

                        if (GetPerson(p.LastName, p.FirstName) != null)
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("PersonID", p.PersonID);
                            command.Parameters.AddWithValue("FirstName", p.FirstName);
                            command.Parameters.AddWithValue("LastName", p.LastName);
                            command.Parameters.AddWithValue("EmailAddress", p.EmailAddress);

                            connection.Open();

                            command.ExecuteNonQuery();

                            scope.Complete();
                        }
                    }
                }
            }
        }

        public List<Person> RankPersonByDistanceTravelled()
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                using (var command = new SqlCommand("SpaceFlight.RankPersonByDistanceTravelled", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslatePersons(reader);
                }
            }
        }

        /// <summary>
        /// Converts sql reader into Person class.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private Person TranslatePerson(SqlDataReader reader)
        {
            var personIdOrdinal = reader.GetOrdinal("PersonId");
            var firstNameOrdinal = reader.GetOrdinal("FirstName");
            var lastNameOrdinal = reader.GetOrdinal("LastName");
            var emailOrdinal = reader.GetOrdinal("EmailAddress");

            if (!reader.Read())
                return null;

            return new Person(
               reader.GetInt32(personIdOrdinal),
               reader.GetString(firstNameOrdinal),
               reader.GetString(lastNameOrdinal),
               reader.GetString(emailOrdinal));
        }

        /// <summary>
        /// Converts sql data into list of persons.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private List<Person> TranslatePersons(SqlDataReader reader)
        {
            var personIdOrdinal = reader.GetOrdinal("PersonId");
            var firstNameOrdinal = reader.GetOrdinal("FirstName");
            var lastNameOrdinal = reader.GetOrdinal("LastName");
            var emailOrdinal = reader.GetOrdinal("EmailAddress");
            var distanceOrdinal = reader.GetOrdinal("DistanceTravelled");

            List<Person> persons = new List<Person>();

            while(reader.Read())
            {
                Person p = new Person(
                reader.GetInt32(personIdOrdinal),
                reader.GetString(firstNameOrdinal),
                reader.GetString(lastNameOrdinal),
                reader.GetString(emailOrdinal));

                p.DistanceTravelled = reader.GetDouble(distanceOrdinal);

                persons.Add(p);
            }

            return persons;
        }
    }
}
