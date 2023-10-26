using Microsoft.AspNetCore.Mvc;
using Postman.API.Models;
using Postman.Domain.Entities;
using Postman.Persistence.Contexts;

namespace Postman.API.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		readonly PostmanDbContext _context;

		public UsersController(PostmanDbContext context)
		{
			_context = context;
		}

		[HttpGet("[action]")]
		public IActionResult GetAll()
		{
			return Ok(_context.Users.ToList());
		}



		[HttpPost("[action]")]

		public IActionResult CreateUser([FromBody] CreateUserRequest createUserRequest)
		{
			User user = new()
			{
				FirstName = createUserRequest.FirstName,
				LastName = createUserRequest.LastName,
			};

			_context.Users.Add(user);

			//_context.SaveChanges();

			return Ok();
		}

		[HttpGet("[action]")]
		public string GetSomething(string name)
		{
			return name.Substring(0, 2);
		}
	}
}
