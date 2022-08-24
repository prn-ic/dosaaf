using Dosaaf.Models;
using Dosaaf.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dosaaf.Components
{
    public class EducationOnlineViewComponent: ViewComponent
    {
        private readonly ApplicationContext _db;
        public EducationOnlineViewComponent(ApplicationContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            IEnumerable<OnlineEducation> onlineEducations = _db.OnlineEducations.ToList();
            return View("EducationOnline", onlineEducations);
        }
    }
}
