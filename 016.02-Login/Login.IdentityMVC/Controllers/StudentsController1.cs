using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Login.IdentityMVC.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
