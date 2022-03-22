using Microsoft.AspNetCore.Mvc;

namespace MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
