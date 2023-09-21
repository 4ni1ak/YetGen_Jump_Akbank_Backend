using _002._01_OOP.Common;
using _002._01_OOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002._01_OOP.Entities
{
    public class Student:PersonBase
    {
  
        public int No { get; set; }

        public DateTimeOffset RegistrationDate { get; set; }


    }
}
