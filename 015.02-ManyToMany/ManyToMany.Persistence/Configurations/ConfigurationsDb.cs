using Microsoft.Extensions.Configuration;

namespace ManyToMany.Persistence.Configurations
{
    public static class ConfigurationsDb
    {
        public static string GetString(string key)
        {
            ConfigurationManager configurationManager = new();

            string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).FullName}\\ManyToMany.Persistence\\Configurations";

            configurationManager.SetBasePath(path);

            configurationManager.AddJsonFile("PrivateInformations.json"); 

            return configurationManager.GetSection(key).Value;
        }

    }
}
