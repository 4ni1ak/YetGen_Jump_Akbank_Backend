using Singleton1.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton1.Domain
{
    internal class Class1
    {

        private readonly IConfigurationsService _configurationsService;
        public Class1(IConfigurationsService configurationsService)
        {
            _configurationsService = configurationsService;
        }
        
    }
}
