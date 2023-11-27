using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidation.Persistence.Configurations
{
    public static class ConfigurationsDb
    {
        public static string GetString(string key)
        {
            ConfigurationManager configurationManager = new();

            string path =
                $"C:\\Users\\Bhs\\Desktop\\Yetgen-basvuru\\016.03-FluentValidation\\Infrastructure\\FluentValidation.Persistence\\Configurations";
                //$"{Directory.GetParent(Directory.GetCurrentDirectory()).FullName}\\Infrastructure\\FluentValidation.Persistence\\Configurations";

            configurationManager.SetBasePath(path);

            configurationManager.AddJsonFile("PrivateInformations.json");

            return configurationManager.GetSection(key).Value;
        }

    }
}
