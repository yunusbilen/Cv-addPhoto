using AreasWithAuth.Data;
using AreasWithAuth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AreasWithAuth.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExperienceController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ExperienceController(ApplicationDbContext db)
        {
            _db= db;
        }

        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return Json(new { data = _db.Experiences.ToList<Experience>() }); ;
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(Experience experience) { 
        
            _db.Experiences.Add(experience);
            _db.SaveChanges();
            return Json(experience);
        }
    }
}
