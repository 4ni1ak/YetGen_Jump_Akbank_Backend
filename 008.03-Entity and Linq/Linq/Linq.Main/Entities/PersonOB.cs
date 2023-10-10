using Linq.Main.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Main.Entities
{
    internal class PersonOB
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public PersonOB(string firstName, string lastName, int age, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }
    }
}
