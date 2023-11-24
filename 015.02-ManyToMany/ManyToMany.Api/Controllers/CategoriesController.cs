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
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CategoriesController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetbyIdCategoryAync(Guid id, CancellationToken cancellationToken)
        {
            var category = await _applicationDbContext
                .Categories
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);


            // var products = await _applicationDbContext.Products.Where(x => x.CategoryId == id);
            return Ok(category);
        }
    
       

        /*oneto*/
        //HttpGet("{id:guid}")]
        //public async Task<IActionResult> GetbyIdAync(Guid id, CancellationToken cancellationToken)
        //{
        //    var category = await _applicationDbContext
        //        .Categories
        //        .AsNoTracking()
        //        .Include(x => x.Products)
        //        .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);


        //    // var products = await _applicationDbContext.Products.Where(x => x.CategoryId == id);
        //    return Ok(category);
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

        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategoriAsync(CategoryAddDto categoryAddDto, CancellationToken cancellationToken)
        {
            if (categoryAddDto is null)
            {
                return BadRequest("Category's name cannot be null");

            }

            var category = new Category()
            {
                Id=Guid.NewGuid(),
                Name = categoryAddDto.Name,
                CreatedByUserId = "4ni1ak",
                CreatedOn = DateTimeOffset.UtcNow,
                IsDeleted = false
            };
            
            await _applicationDbContext.Categories.AddAsync(category);
            
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return Ok(category);
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync( CancellationToken cancellationToken)
        {
            var categories = await _applicationDbContext
                .Categories
                .AsNoTracking()
                .ToListAsync(cancellationToken);


            // var products = await _applicationDbContext.Products.Where(x => x.CategoryId == id);
            return Ok(categories);
        }

        [HttpPost("UpdateProduct")]
        public async Task<IActionResult> UpdateProductAsync(Guid id,ProductAddDto productAddDto, CancellationToken cancellationToken)
        {
            var product = await _applicationDbContext
                .Products
                .FirstOrDefaultAsync(x=>x.Id==id,cancellationToken);

            _applicationDbContext.Products.Update(product);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
            return Ok(product);
        }
    }
}
