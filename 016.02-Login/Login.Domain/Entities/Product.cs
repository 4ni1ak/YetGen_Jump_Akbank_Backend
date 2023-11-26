namespace Login.Domain.Entities;

public class Product: EntityBase<Guid>
{
    public string Name { get; set; }
    //public Guid CategoryId { get; set; }
    //public Category Category { get; set; }
        
    public ICollection<ProductCategory> ProductCategories{ get; set; }


}