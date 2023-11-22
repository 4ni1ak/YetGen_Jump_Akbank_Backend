using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Singleton1.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public CustomersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public void Get(string name)
        {
            string value = _configuration.GetValue<string>(name);
      
        }
    }
}
