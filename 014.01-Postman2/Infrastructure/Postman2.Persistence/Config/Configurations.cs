using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman2.Persistence.Config
{
    public static class Configurations
    {
        public static string GetString(string key)
        {
            ConfigurationManager configurationManager = new();

            string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName}\\014.01-Postman2\\Infrastructure\\Postman2.Persistence\\Config";
            Console.WriteLine(path);
            configurationManager.SetBasePath(path);
            configurationManager.AddJsonFile("PrivateInformations.json");
            return configurationManager.GetSection(key).Value;
        }
    }
}
