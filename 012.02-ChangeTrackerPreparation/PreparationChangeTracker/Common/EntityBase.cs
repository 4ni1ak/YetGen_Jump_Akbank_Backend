using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationChangeTracker.Common
{
	internal class EntityBase<Tkey>: ICreateByEntity, IModifiedByEntity
	{
		public Tkey Id { get; set; }
		public DateTime CreatedOn { get; set; }
		public DateTime? ModifiedOn { get; set; }



	}
}
