using Postman2.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman2.Domain.Entities
{
	public class Passenger : Person
	{
		public string City { get; set; }
	}
}
