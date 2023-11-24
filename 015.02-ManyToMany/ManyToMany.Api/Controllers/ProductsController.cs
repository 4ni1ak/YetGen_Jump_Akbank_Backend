using ManyToMany.Domain.Dtos;
using ManyToMany.Domain.Entities;
using ManyToMany.Persistence.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ManyToMany.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductsController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        #region ManyTo
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetbyIdAync(Guid id, CancellationToken cancellationToken)
        {
            var product = await _applicationDbContext
                .Products
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            var categories = product.ProductCategories.Select(x => x.Category);


            // var products = await _applicationDbContext.Products.Where(x => x.CategoryId == id);
            return Ok(product);
        }
        [HttpGet("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts(CancellationToken cancellationToken)
        {
            var products = await _applicationDbContext
                .Products
                .AsNoTracking()
                .ToListAsync(cancellationToken);

            // var products = await _applicationDbContext.Products.Where(x => x.CategoryId == id);
            return Ok(products);

        }
        [HttpPost("AddProduct")]
        public async Task<IActionResult> AddAsync(ProductAddDto productAddDto, CancellationToken cancellationToken)
        {
            if (productAddDto is null || string.IsNullOrEmpty(productAddDto.Name))
            {
                return BadRequest("Product's name cannot be null");

            }




            var id = Guid.NewGuid();

            List<ProductCategory> productCategories = new List<ProductCategory>();
            if (productAddDto.CategoryIds is null && !productAddDto.CategoryIds.Any())
            {

                foreach (var categoryId in productAddDto.CategoryIds)
                {
                    var productCategory = new ProductCategory()
                    {
                        CategoryId = categoryId,
                        ProductId = id,
                        CreatedOn = DateTimeOffset.UtcNow,
                        CreatedByUserId = "4ni1ak"
                    };

                    productCategories.Add(productCategory);
                }
            }

            var product = new Product()
            {
                Id = id,
                Name = productAddDto.Name,
                CreatedByUserId = "4ni1ak",
                CreatedOn = DateTimeOffset.UtcNow,
                IsDeleted = false,
                ProductCategories = productCategories,
            };

            await _applicationDbContext.Products.AddAsync(product, cancellationToken);

            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return Ok(product);
        }

        [HttpPost("UpdateProduct")]
        public async Task<IActionResult> UpdateProductAsync(Guid id, ProductAddDto productAddDto, CancellationToken cancellationToken)
        {
            var product = await _applicationDbContext
                .Products
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

            _applicationDbContext.Products.Update(product);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
            return Ok(product);
        }
        [HttpGet("GetAllProductsAsync")]
        public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
        {
            var products = await _applicationDbContext
                .Products
                .Include(x => x.ProductCategories)
                .ThenInclude(x => x.Category)
                .AsNoTracking()
                .Select(x => new ProductDto()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Categories = x.ProductCategories.Select(x => new ProductGetAllCategoryDto()
                    {
                        Id = x.Category.Id,
                        Name = x.Category.Name,
                    }).ToList()

                    //Category = new CategoryDto()
                    //{
                    //    Id = x.Id,
                    //    Name = x.Name,
                    //},
                }).ToListAsync(cancellationToken);

            return Ok(products);
        }
        #endregion

        #region Oneto
        //[HttpGet("{id:guid}")]
        //public async Task<IActionResult> GetbyIdAync(Guid id, CancellationToken cancellationToken)
        //{
        //    var product = await _applicationDbContext
        //        .Products
        //        .AsNoTracking()
        //        .Include(x => x.Category)
        //        .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        //    var categoryName = product.Category.Name;

        //   // var products = await _applicationDbContext.Products.Where(x => x.CategoryId == id);
        //   return Ok(product);
        //}
        //[HttpGet]
        //public async Task<IActionResult> GetAllProducts(CancellationToken cancellationToken)
        //{
        //    var products = await _applicationDbContext
        //        .Products
        //        .Include(x => x.Category)
        //        .AsNoTracking()
        //        .ToListAsync(cancellationToken);

        //    // var products = await _applicationDbContext.Products.Where(x => x.CategoryId == id);
        //    return Ok(products);

        //}
        //[HttpPost("AddProduct")]
        //public async Task<IActionResult> AddProductAsync(ProductAddDto productAddDto, CancellationToken cancellationToken)
        //{
        //    if (productAddDto is null || string.IsNullOrEmpty(productAddDto.Name) || productAddDto.CategoryId == Guid.Empty)
        //    {
        //        return BadRequest("Product's name cannot be null");

        //    }

        //    var product = new Product()
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = productAddDto.Name,
        //        CategoryId = productAddDto.CategoryId,
        //        CreatedByUserId = "4ni1ak",
        //        CreatedOn = DateTimeOffset.UtcNow,
        //        IsDeleted = false
        //    };

        //    await _applicationDbContext.Products.AddAsync(product, cancellationToken);

        //    await _applicationDbContext.SaveChangesAsync(cancellationToken);

        //    return Ok(product);
        //}

        //[HttpPost("UpdateProduct")]
        //public async Task<IActionResult> UpdateProductAsync(Guid id, ProductAddDto productAddDto, CancellationToken cancellationToken)
        //{
        //    var product = await _applicationDbContext
        //        .Products
        //        .Include(x => x.Category)
        //        .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        //    _applicationDbContext.Products.Update(product);
        //    await _applicationDbContext.SaveChangesAsync(cancellationToken);
        //    return Ok(product);
        //}
        //[HttpGet]
        //public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
        //{
        //    var products = await _applicationDbContext
        //        .Products
        //        .AsNoTracking()
        //        .Select(x => new ProductDto()
        //        {
        //            Id = x.Id,
        //            Name = x.Name,
        //            Category = new CategoryDto()
        //            {
        //                Id = x.CategoryId,
        //                Name = x.Category.Name,
        //            },

        //            CreatedOn = x.CreatedOn
        //        })
        //        .ToListAsync(cancellationToken);


        //    // var products = await _applicationDbContext.Products.Where(x => x.CategoryId == id);
        //    return Ok(products);
        //}
        #endregion

    }
}
