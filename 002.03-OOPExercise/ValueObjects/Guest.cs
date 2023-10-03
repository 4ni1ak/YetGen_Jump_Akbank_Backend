using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002._03_OOPExercise.ValueObject
{
    public class Guest
    {
       
        public string Name{ get; set; }
        public string Surname{ get; set; }
        public string IdNumber{ get; set; }
        public string PhoneNumber{ get; set; }
        public Guest()
        {
            
        }
        public Guest(string name, string surname, string ıdNumber, string phoneNumber)
        {
          
            Name = name;
            Surname = surname;
            IdNumber = ıdNumber;
            PhoneNumber = phoneNumber;
        }

    }
}
