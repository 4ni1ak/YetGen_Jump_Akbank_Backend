using DIAndDInjection.Api.Services;
using DIAndDInjection.Shared.Services;
using DIAndDInjection.Shared.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIAndDInjection.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextsController : ControllerBase
    {
        private readonly RequestCountService _requestCountService;
        private readonly ITextService _textService;
        public TextsController(ITextService textService, RequestCountService requestCountService) 
        {
            _requestCountService = requestCountService;
            //_textService = new ITextService("C:\\Users\\Bhs\\Desktop\\");
            _textService = textService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            _requestCountService.Count += 1;
            return Ok(); 
        }
    }
}
