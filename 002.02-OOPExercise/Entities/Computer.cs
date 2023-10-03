using _002._02_OOPExercise.ComputerComponents;
using _002._02_OOPExercise.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002._02_OOPExercise.Entities
{
    public class Computer
    {
        public int Id { get; set; }
        public string Brand{ get; set; }
        public string Model { get; set; }
        public string CPU { get; set; }
        public RAM RAM { get; set; }
        public Storage Storage { get; set; }

        
        public Computer()
        {
            Random random = new Random();

            Id = random.Next(1000, int.MaxValue);

        }
        public Computer(string brand, string model) : this()
        {
            Brand = brand;
            Model = model;
        
        }
        public Computer(string brand, string model, string cPU, RAM rAM, Storage  storage) : this(brand, model)
        {
            CPU = cPU;
            RAM = rAM;
            Storage = storage;
        }
    
    }
}
