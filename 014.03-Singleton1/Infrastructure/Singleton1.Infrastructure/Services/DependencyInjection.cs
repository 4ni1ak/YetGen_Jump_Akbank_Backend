using Microsoft.Extensions.DependencyInjection;
using Singleton1.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton1.Infrastructure.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSharedServices(this IServiceCollection services)
        {
            services.AddSingleton<IConfigurationsService>();
            return services;
        }
    }
}
