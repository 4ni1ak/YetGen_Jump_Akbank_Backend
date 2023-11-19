
using DIAndDInjection.Shared.Services;
using DIAndDInjection.Shared.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;


namespace DIAndDInjection.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrazyPasswordsController : ControllerBase
    {
        private readonly PasswordGenerator _passwordGenerator;
        private readonly RequestCountService _requestCountService;
        private readonly ITextService _textService;
        private readonly IIPService _ipService;
        public CrazyPasswordsController(PasswordGenerator passwordGenerator, RequestCountService requestCountService, ITextService textService, IIPService iPService)
        {
            _passwordGenerator = passwordGenerator;
            _requestCountService = requestCountService;
            _textService = textService;
            _ipService = iPService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _requestCountService.Count += 1;

            _ipService.Ip = "192.168.1.8";

            return Ok(_passwordGenerator.Generate(12, true, true, true, true));
        }

        [HttpGet("GetCount")]
        public IActionResult GetCount()
        {
            _requestCountService.Count += 1;
            return Ok(_passwordGenerator.GeneratedPasswordsCount);
        }

        [HttpGet("GetRequestCount")]
        public IActionResult GetRequestCount()
        {
            _requestCountService.Count += 1;

            return Ok(_requestCountService.Count);
        }

    }
}
