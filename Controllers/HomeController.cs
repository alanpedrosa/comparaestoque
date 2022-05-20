using Microsoft.AspNetCore.Mvc;

namespace Comparador.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
