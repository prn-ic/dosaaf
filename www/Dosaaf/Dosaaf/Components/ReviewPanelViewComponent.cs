using Dosaaf.Models;
using Dosaaf.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dosaaf.Components
{
    public class ReviewPanelViewComponent: ViewComponent
    {
        private readonly ApplicationContext _db;
        public ReviewPanelViewComponent(ApplicationContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            IEnumerable<Review> reviews = _db.Reviews.ToList();

            return View("ReviewPanel", reviews);
        }
    }
}
