using Microsoft.AspNetCore.Mvc;

namespace OneToManyDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
