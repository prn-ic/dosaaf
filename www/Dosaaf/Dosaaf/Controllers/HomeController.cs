using Microsoft.AspNetCore.Mvc;

namespace Dosaaf.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
