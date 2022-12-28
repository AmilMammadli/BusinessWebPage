using Microsoft.AspNetCore.Mvc;

namespace BusinessWebSite.Areas.admin.Controllers
{
    [Area("admin")]
    public class DashboardController : Controller
    {
        private object _context;

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string name)
        {
            return Json(name);
        }
        public IActionResult Delete(int id)
        {
            WorkCategory work = _context.WorkCategories.Find(id);
            if (work == null)
            {
                return NotFound();
            }
            _context.WorkCategories.Remove(work);
            _context.SaveChanges();
            return RedirectToAction(nameof(Categories));
        }
    }
}
