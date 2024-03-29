﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team08.Models
{
    public class Person
    {
        public int PersonID;
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        private double distanceTravelled;

        public Person(int personID, string firstName, string lastName, string emailAddress)
        {
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }

        public double DistanceTravelled { get => distanceTravelled; set => distanceTravelled = value; }
    }
}
