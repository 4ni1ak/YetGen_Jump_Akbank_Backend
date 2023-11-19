using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIAndDInjection.Shared
{
    public static class IntegerExtensions
    {
        public static bool IsEven(this int value)
        {
            if (value % 2 == 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
