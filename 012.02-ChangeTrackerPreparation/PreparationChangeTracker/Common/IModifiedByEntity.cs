using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationChangeTracker.Common
{
	internal interface IModifiedByEntity
	{
		public DateTime? ModifiedOn { get; set; }

	}
}
