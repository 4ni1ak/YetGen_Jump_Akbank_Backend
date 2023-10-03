using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Domain.Common
{
    public class EntityBase<TKey> : IModifiedOn
    {
        public TKey Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }

        private DateTimeOffset modifiedOn;

        public DateTimeOffset GetModifiedOn()
        {
            return modifiedOn;
        }

        public void SetModifiedOn(DateTimeOffset value)
        {
            modifiedOn = value;
        }

        private string modifiedBy;

        public string GetModifiedBy()
        {
            return modifiedBy;
        }

        public void SetModifiedBy(string value)
        {
            modifiedBy = value;
        }
    }
}
