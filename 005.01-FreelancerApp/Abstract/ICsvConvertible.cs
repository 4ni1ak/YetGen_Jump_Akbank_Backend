using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005._01_FreelancerApp.Abstract
{
    internal interface ICsvConvertible
    {
        string GetValuesCSV();
        void SetValuesCSV(string csv);
    }
}
