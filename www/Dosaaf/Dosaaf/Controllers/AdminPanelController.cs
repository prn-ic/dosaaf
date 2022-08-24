using Dosaaf.Models;
using Dosaaf.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Dosaaf.Controllers
{
    public class AdminPanelController : Controller
    {
        private readonly ApplicationContext _db;
        private readonly IEncryptionService _encryptionService;

        public AdminPanelController(ApplicationContext db, IEncryptionService encryptionService)
        {
            _db = db;
            _encryptionService = encryptionService;
        }

        [Route("AdminPanel/Index")]
        public IActionResult Index()
        {
            return View();
        }
      
        [Route("AdminPanel/Management")]
        public IActionResult Management()
        {
            if (Request.Cookies.Keys.FirstOrDefault(x => x == "authKey") == null)
            {
                Console.WriteLine("yes");
                return Redirect("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult DeleteReview(string Id)
        {
            var review = _db.Reviews.FirstOrDefault(
                x => x.Id == int.Parse(Id)
            );
            _db.Reviews.Remove(review!);
            _db.SaveChanges();

            return Redirect("Management");
        }

        [HttpPost]
        public IActionResult Login(Admin admin)
        {
            Admin? person = _db.Admins.FirstOrDefault(
                x => 
                x.Name == admin.Name && 
                x.Password == _encryptionService.Base64Encode(admin.Password!)
            );

            if (person is null)
            {
                return Redirect("Index");
            }    
                
            Response.Cookies.Append(
                "authKey",
                _encryptionService.Base64Encode(admin.Name!)
            );
            return Redirect("Management");
        }
    }
}
