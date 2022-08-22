using Dosaaf.Models;
using Dosaaf.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dosaaf.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext _db;
        private readonly ILogger<HomeController> _logger;
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
        public HomeController(ApplicationContext db, ILogger<HomeController> logger)
        {
            _db = db;
            _logger = logger;
        }

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
        [HttpPost]
        public IActionResult OnlineEducation(OnlineEducationModel onlineEducationModel)
        {
            onlineEducationModel.TimeCreated = DateTime.Now;
            _db.OnlineEducations.Add(onlineEducationModel);
            _db.SaveChanges();
            return Redirect("OnlineEducation");
        }
        [HttpPost]
        public IActionResult RecordEducation(EducationModel educationModel)
        {
            educationModel.TimeCreated = DateTime.Now;
            _db.Educations.Add(educationModel);
            _db.SaveChanges();
            return Redirect("/");
        }
        public IActionResult RecordEducation()
        {
            ViewBag.Categories = new SelectList(categories, "Name", "Name");
            return View();
        }
        public IActionResult Feedback()
        {
            IEnumerable<Review> reviews = _db.Reviews.ToList();

            ViewBag.Reviews = reviews;

            return View();
        }
        [HttpPost]
        public IActionResult Feedback(Review review)
        {
            review.TimeCreated = DateTime.Now;
            _db.Reviews.Add(review);
            _db.SaveChanges();
            return Redirect("Feedback");
        }
    }
}
