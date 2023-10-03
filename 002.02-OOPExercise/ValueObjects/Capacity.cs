using _002._02_OOPExercise.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002._02_OOPExercise.ValueObjects
{
    public class Capacity
    {
        public Capacity(int size, CapacitySizeType sizeType)
        {
            Size = size;
            SizeType = sizeType;
        }

        public int Size { get; set; }
        public CapacitySizeType SizeType { get; set; }

    }
}
