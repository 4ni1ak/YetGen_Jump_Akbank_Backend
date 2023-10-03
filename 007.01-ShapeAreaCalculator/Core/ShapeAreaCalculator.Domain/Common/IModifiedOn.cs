using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Domain.Common
{
    internal interface IModifiedOn
    {
        DateTimeOffset GetModifiedOn();
        void SetModifiedOn(DateTimeOffset value);
        string GetModifiedBy();
        void SetModifiedBy(string value);
    }
}
