using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005._01_FreelancerApp.Constants
{
    internal class FileLocations
    {
        public static string ProjectFolder => Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
    }
}
