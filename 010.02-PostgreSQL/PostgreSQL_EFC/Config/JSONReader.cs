using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQL_EFC.Config
{
	public class JSONReader
	{
		public string ServerIP { get; set; }
		public string Port { get; set; }
		public string Database { get; set; }
		public string UserId { get; set; }
		public string Password { get; set; }

		public async Task ReadJSON()
		{
			using (StreamReader reader = new StreamReader("config.json"))
			{
				string json = await reader.ReadToEndAsync();
				JsonStructure data = JsonConvert.DeserializeObject<JsonStructure>(json);
				this.ServerIP = data.ServerIP;
				this.Port = data.Port;
				this.Database = data.Database;
				this.UserId = data.UserId;
				this.Password = data.Password;
			}
		}
	}

	internal sealed class JsonStructure
	{
		public string ServerIP { get; set; }
		public string Port { get; set; }
		public string Database { get; set; }
		public string UserId { get; set; }
		public string Password { get; set; }
		public string Token { get; set; }
		public string Prefix { get; set; }
	}
}
