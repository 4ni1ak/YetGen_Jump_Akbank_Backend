using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationChangeTracker.Config
{
	public static class Configurations
	{
		public static string GetString(string key)
		{
			ConfigurationManager configurationManager = new();

			string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\Config";

			configurationManager.SetBasePath(path);

			configurationManager.AddJsonFile("PrivateInformations.json"); //PrivateInformations.json must be PrivateInformations2.json !!!!!!!!

			return configurationManager.GetSection(key).Value;
		}

	}
}
