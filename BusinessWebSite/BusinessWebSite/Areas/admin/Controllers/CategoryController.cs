using Microsoft.AspNetCore.Mvc;

namespace BusinessWebSite.Areas.admin.Controllers
{
    [Area("admin")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
