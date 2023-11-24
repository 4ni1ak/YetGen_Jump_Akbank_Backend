using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManyToMany.Domain.Entities
{

    public class ProductCategory : ICreatedByEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public string CreatedByUserId { get; set; }
        public DateTimeOffset CreatedOn { get; set; }

    }

    /*
     * mor control
     */
    //public class ProductCategory : EntityBase<Guid>
    //{
    //    public override Guid Id { get; set; }
    //    public Guid ProductId { get; set; }
    //    public Product Product { get; set; }
    //    public Guid CategoryId { get; set; }
    //    public Category Category { get; set; }

    //    public string CreatedByUserId { get; set; }
    //    public DateTimeOffset CreatedOn { get; set; }

    //}
}
