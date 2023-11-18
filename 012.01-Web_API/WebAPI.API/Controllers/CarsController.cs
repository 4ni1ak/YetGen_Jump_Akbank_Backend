using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using WebAPI.API.Data;

namespace WebAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var cars = CarsContext.LuxuryCars.ToList();

            return Ok(cars);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {

            if (id == Guid.Empty)
                return BadRequest("Id cannot be empty.");

            var car = CarsContext.LuxuryCars.FirstOrDefault(x => x.Id == id);

            if (car is null)
                return NotFound("The car requested with given Id was not found.");

            return Ok(car);
        }
    }
}
