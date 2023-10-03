using _003._01_ReferenceTypeValueType.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003._01_ReferenceTypeValueType.Entities
{
    public class Car
    {
        public string Model { get; }
        public CarType Type { get; }
        public bool IsRented { get; private set; }

        public Car(string model, CarType type)
        {
            Model = model;
            Type = type;
            IsRented = false;
        }

        public void Rent()
        {
            if (!IsRented)
            {
                IsRented = true;
            }
        }

        public void Return()
        {
            if (IsRented)
            {
                IsRented = false;
            }
        }
    }
}

