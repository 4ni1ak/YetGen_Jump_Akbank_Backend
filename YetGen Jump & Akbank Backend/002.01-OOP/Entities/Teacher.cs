using _002._01_OOP.Common;
using _002._01_OOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002._01_OOP.Entities
{
    public class Teacher : PersonBase
    {

        public DateTimeOffset RegistrationDate { get; set; }

        public string FullName => $"{FirstName}{LastName}";
        public void SayMyName()
        {
            Console.WriteLine( $"{FirstName}{LastName}");

        }
    }
}
