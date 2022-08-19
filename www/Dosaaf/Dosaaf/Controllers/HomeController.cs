using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dosaaf.Controllers
{
    public class HomeController : Controller
    {
        public record Category(int Id, string Name);
        IEnumerable<Category> categories = new List<Category> {
            new Category (1, "Категория А"),
            new Category (2, "Категория В"),
            new Category (3, "Категория С (c 'В' на 'C')"),
            new Category (4, "Категория С (c 'С' на 'В')"),
            new Category (5, "Категория С (c 'В' на 'Д')"),
            new Category (6, "Категория CE"),
            new Category (7, "Теоретический минимум")
            
        };
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
        public IActionResult OnlineEducation()
        {
            ViewBag.Categories = new SelectList(categories, "Name", "Name");
            return View();
        }
        public IActionResult RecordEducation()
        {
            ViewBag.Categories = new SelectList(categories, "Name", "Name");
            return View();
        }
    }
}
