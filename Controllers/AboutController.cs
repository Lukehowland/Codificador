using Microsoft.AspNetCore.Mvc;

namespace LukeCodificador.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult SobreElInge()
        {
            return View();
        }
    }
}