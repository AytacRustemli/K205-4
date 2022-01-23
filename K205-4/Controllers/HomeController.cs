using Microsoft.AspNetCore.Mvc;

namespace K205_4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
