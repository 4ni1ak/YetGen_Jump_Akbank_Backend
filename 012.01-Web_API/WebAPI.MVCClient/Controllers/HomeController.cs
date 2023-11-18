using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAPI.MVCClient.Models;

namespace WebAPI.MVCClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
      
        public async Task<IActionResult> Index()
        {

   

            return View();
        }
    }
}