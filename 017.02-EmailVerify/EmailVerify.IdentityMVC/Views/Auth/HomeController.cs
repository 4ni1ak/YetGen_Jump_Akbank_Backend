using Microsoft.AspNetCore.Mvc;

namespace EmailVerify.IdentityMVC.Views.Auth
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
