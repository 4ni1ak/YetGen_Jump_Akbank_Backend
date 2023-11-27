using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Domain.Common;

namespace FluentValidation.Domain.Entities
{
    public class BankAccount:EntityBase<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber{ get; set; }
        public string Balance { get; set; }
        
    }
}
