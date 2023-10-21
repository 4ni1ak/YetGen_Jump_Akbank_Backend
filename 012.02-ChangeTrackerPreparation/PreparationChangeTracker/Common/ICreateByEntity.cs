using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationChangeTracker.Common
{
	internal interface ICreateByEntity
	{
		public DateTime CreatedOn { get; set; }
		//public string CreatedByUserId  { get; set; }
	}
}
