using DIAndDInjection.Shared.Utilities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIAndDInjection.Shared
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSharedServices(this IServiceCollection services) 
        {
            services.AddSingleton<IDGenerator> ();
            return services;
        }
    }
}
