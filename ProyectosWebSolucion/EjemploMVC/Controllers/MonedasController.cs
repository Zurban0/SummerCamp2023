using Microsoft.AspNetCore.Mvc;

namespace EjemploMVC.Controllers
{
    public class MonedasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
