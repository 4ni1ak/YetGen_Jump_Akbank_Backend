using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004._02_EncapsulationExercise.Entities
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname{ get; set; }
        private decimal balance { get; set; }
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (Math.Abs(value - balance) <=500 )
                {
                    balance = value;
                    Console.WriteLine($"Current value {balance}");

                }
            }
        }

        public Account(string name, string surname)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Balance = 2000;
        }
      

    }
}
