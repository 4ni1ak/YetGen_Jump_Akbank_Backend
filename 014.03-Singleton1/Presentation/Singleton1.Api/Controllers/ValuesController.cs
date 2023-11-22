using Microsoft.AspNetCore.Mvc;
using Singleton1.Infrastructure.Services;

namespace Singleton1.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ValuesController(IConfiguration configuration)
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
