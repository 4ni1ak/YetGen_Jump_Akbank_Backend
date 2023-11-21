using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingAndFluentApi.Persistence.Configurations
{
    public static class ConfigurationsDb
    {
        public static string GetString(string key)
        {
            ConfigurationManager configurationManager = new();

            string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).FullName}\\HashingAndFluentApi.Persistence\\Configurations";

            configurationManager.SetBasePath(path);

            configurationManager.AddJsonFile("PrivateInformations.json"); 

            return configurationManager.GetSection(key).Value;
        }

    }
}
