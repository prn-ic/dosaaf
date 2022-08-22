using Dosaaf.Models;
using Dosaaf.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dosaaf.Components
{
    public class EducationViewComponent: ViewComponent
    {
        private readonly ApplicationContext _db;
        public EducationViewComponent(ApplicationContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            IEnumerable<EducationModel> educations = _db.Educations.ToList();
            return View("Education", educations);
        }
    }
}
