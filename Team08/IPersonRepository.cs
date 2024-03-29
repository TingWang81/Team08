﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team08.Models;

namespace Team08
{
    public interface IPersonRepository
    {
        Person GetPerson(string lastName, string firstName);

        void InsertPersonIfNonExistent(Person p);

        List<Person> RankPersonByDistanceTravelled();

        void UpdatePerson(Person p);
    }
}
