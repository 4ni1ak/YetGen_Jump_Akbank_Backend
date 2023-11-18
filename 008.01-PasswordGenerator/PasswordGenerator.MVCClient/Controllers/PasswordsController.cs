using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.MVCClient.Models;
using Yetgen.PWGenerator;

namespace PasswordGenerator.MVCClient.Controllers
{
    public class PasswordsController : Controller
    {

        private readonly PasswordsGenerator _passwordGenerator;

        public PasswordsController()
        {

        }

        [HttpGet]
        public IActionResult Index()
        {
            var indexViewModel = new PasswordsIndexViewModel();

            indexViewModel.Password = _passwordGenerator.Generate(15, true, true, true, true);


            return View(indexViewModel);
        }


        [HttpPost]
        public IActionResult Index(int passwordLength)
        {
            //var indexViewModel = new PasswordsIndexViewModel();

            //indexViewModel.Password = _passwordGenerator.Generate(passwordLength, true, true, true, true);

            //return View(indexViewModel);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Add()
        {
            var indexViewModel = new PasswordsIndexViewModel();

            indexViewModel.Password = _passwordGenerator.Generate(15, true, true, true, true);


            return View(indexViewModel);
        }


        [HttpPost]
        public IActionResult Add(PasswordsIndexViewModel passwordModel)
        {
            return View();
        }
    }
}
