using PostgreSQL_EFC.Contexts;
using PostgreSQL_EFC.Entities;

ShopifyDbContext _context = new ShopifyDbContext();
#region Add-Single
Product product1 = new("Zippo gold Lighter", 0.2m, 2000m);

_context.Products.Add(product1);
_context.SaveChanges();
#endregion

#region Add-Multiple
List<Product> zippoProducts = new List<Product>
{
    new Product("Zippo Classic Brushed Chrome Lighter", 0.1m, 19.99m),
    new Product ("Zippo Armor High Polish Chrome Lighter", 0.12m, 29.99m),
    new Product("Zippo Vintage Windproof Lighter with Slashes", 0.11m, 24.99m),
    new Product("Zippo Matte Pocket Lighter", 0.08m, 17.99m),
    new Product("Zippo Harley-Davidson Eagle Lighter", 0.1m, 34.99m),
    new Product("Zippo Slim Spectrum Lighter", 0.08m, 22.99m),
    new Product("Zippo Jack Daniel's Label Brass Lighter", 0.1m, 27.99m),
    new Product("Zippo Venetian High Polish Chrome Lighter", 0.12m, 26.99m),
    new Product("Zippo American Flag Lighter", 0.1m, 21.99m),
    new Product("Zippo Black Ice Lighter", 0.09m, 18.99m),
    new Product("Zippo Vintage High Polish Brass Lighter", 0.11m, 25.99m),
    new Product("Zippo Street Chrome Lighter", 0.08m, 16.99m),
    new Product ("Zippo Dragon Design Lighter", 0.1m, 32.99m),
    new Product("Zippo Brushed Brass Lighter", 0.12m, 23.99m),
    new Product("Zippo Anne Stokes Collection Angel Lighter", 0.1m, 30.99m),
    new Product("Zippo Brushed Chrome Lighter with Slashes", 0.09m, 20.99m),
    new Product("Zippo Skull Design Lighter", 0.11m, 28.99m),
    new Product("Zippo Black Matte Lighter", 0.1m, 19.99m),
    new Product("Zippo High Polish Chrome Lighter with Engraved Cross", 0.12m, 31.99m)
};
_context.Products.AddRange(zippoProducts);  
_context.SaveChanges();

#endregion

#region Read-Multiple
List<Product> products = _context.Products.Where(x=>x.Price <25 ).OrderBy(x=>x.Price).ToList();
foreach (var item in products)
{
    Console.WriteLine($"{item.Title}-{item.Price} ");
}

#endregion

#region Read-Single
Product product2 =_context.Products.Where(x => x.Title == "Zippo Dragon Design Lighter").FirstOrDefault();
Console.WriteLine($"{product2.Title}-{product2.Price} ");
Product product3 = _context.Products.Where(x => x.Title.Contains("Black")).FirstOrDefault();
Console.WriteLine($"{product3.Title}-{product3.Price} ");
#endregion