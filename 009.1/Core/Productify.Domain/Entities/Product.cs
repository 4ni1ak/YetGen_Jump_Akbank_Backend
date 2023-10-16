namespace Productify.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string BrandName { get; set; }
        public int StockCount { get; set; }
        

        public Product(string name, string type, decimal price, string brandName, int stockCount)
        {
            Id = Guid.NewGuid();
            Name = name;
            CreatedOn = DateTime.UtcNow;
            Type = type;
            Price = price;
            BrandName = brandName;
            StockCount = stockCount;
        }
    }
}