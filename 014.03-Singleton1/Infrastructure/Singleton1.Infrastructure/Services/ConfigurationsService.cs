using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton1.Application.Interfaces;

namespace Singleton1.Infrastructure.Services
{
    public class ConfigurationsService: IConfigurationsService
    {

        private static ConfigurationsService instance;

       

        public static ConfigurationsService GetInstance()
        {
            if (instance is null)
            {
                instance = new ConfigurationsService();
            }
            return instance;
        }



        public  string GetString(string key)
        {
            ConfigurationManager configurationManager = new();

            string path = $"{Directory.GetCurrentDirectory()}";

            configurationManager.SetBasePath(path);

            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetSection(key).Value;
        }

    }
}
