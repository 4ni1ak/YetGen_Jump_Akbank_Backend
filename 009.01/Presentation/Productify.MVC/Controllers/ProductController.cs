using Microsoft.AspNetCore.Mvc;
using Productify.Domain;
using Productify.Persistence;
using Productify.Persistence.Contexts;

namespace Productify.MVC.Controllers
{
    public class ProductController : Controller
    {
        ProductifyDbContext _context = new ProductifyDbContext();

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(string name, string type, string price, string brandName, string stockCount)
        {
            if (ModelState.IsValid)
            {
                // Formdan gelen string değerleri uygun veri türlerine çevirin.
                if (decimal.TryParse(price, out decimal priceValue))
                {
                    // priceValue şimdi decimal türünde.
                }
                else
                {
                    // Geçersiz bir fiyat girişi, hata işleme ekleyebilirsiniz.
                    ModelState.AddModelError("price", "Lütfen geçerli bir fiyat girin.");
                    return View();
                }

                if (int.TryParse(stockCount, out int stockCountValue))
                {
                    // stockCountValue şimdi int türünde.
                }
                else
                {
                    // Geçersiz stok sayısı girişi, hata işleme ekleyebilirsiniz.
                    ModelState.AddModelError("stockCount", "Lütfen geçerli bir stok sayısı girin.");
                    return View();
                }
                Product product1 = new Product(name,type,priceValue,brandName,stockCountValue);


                // Product nesnesini _context'e ekleyin ve değişiklikleri kaydedin.
                _context.Products.Add(product1);
                _context.SaveChanges();
                // ModelState.IsValid, formdaki verilerin doğru bir şekilde model ile eşleştiğini gösterir.

                // Veritabanına kaydetme veya başka işlemler yapma adımlarını burada gerçekleştirebilirsiniz.

                return RedirectToAction("GetAll"); // Başka bir sayfaya yönlendirme
            }

            // ModelState.IsValid false ise, hatalı girişleri içeren sayfayı tekrar göster
            return View();
        }

        public IActionResult GetAll()
        {
            var products = _context.Products.ToList();
            return View(products);
            
        }
    }
}
