namespace OneToOneAndIdentity.Domain.Entities;

public class Category:EntityBase<Guid>
{
    public string Name { get; set; }
    public ICollection<ProductCategory> ProductCategories { get; set; }
    //public ICollection<Product> Products { get; set; }


}