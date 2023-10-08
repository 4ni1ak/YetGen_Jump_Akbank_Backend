using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq.Main.Enums;

namespace Linq.Main.Entities
{
    internal class Person
    {
        //public Person(string firstName, string lastName, int age, Gender gender)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Age = age;
        //    Gender = gender;
        //}

        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal int Age { get; set; }
        internal Gender Gender { get; set; }

    }
}
