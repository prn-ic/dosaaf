using Microsoft.AspNetCore.Mvc;

namespace Dosaaf.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tips()
        {
            return View();
        }
        public IActionResult Price()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
