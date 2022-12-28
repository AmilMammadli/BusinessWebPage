using Microsoft.AspNetCore.Mvc;

namespace BusinessWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
        public string index2()
        {
            return "index2";
        }
    }
}
