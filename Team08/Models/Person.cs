using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team08.Models
{
    class Person
    {
        public int PersonID;
        public string FirstName;
        public string LastName;
        public string EmailAddress;

        public Person(int personID, string firstName, string lastName, string emailAddress)
        {
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }
    }
}
