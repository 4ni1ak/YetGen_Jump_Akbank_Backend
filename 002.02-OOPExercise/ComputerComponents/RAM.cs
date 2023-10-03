using _002._02_OOPExercise.Enums;
using _002._02_OOPExercise.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002._02_OOPExercise.ComputerComponents
{
    public class RAM
    {
        public RAM()
        {
            
        }
        public RAM(string brand, Capacity capacity)
        {
            Brand = brand;
            Capacity = capacity;
        }

        public string Brand { get; set; }
        public Capacity Capacity { get; set; }

    }
}
