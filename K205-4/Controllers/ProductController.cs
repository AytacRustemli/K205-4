using Microsoft.AspNetCore.Mvc;

namespace K205_4.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
