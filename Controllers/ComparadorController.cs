using Microsoft.AspNetCore.Mvc;

namespace Comparador.Controllers
{
    public class ComparadorController : Controller
    {
        public IActionResult Comparador()
        {
            return View();
        }
    }
}
