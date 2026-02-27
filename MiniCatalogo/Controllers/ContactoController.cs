using Microsoft.AspNetCore.Mvc;

namespace MiniCatalogo.Controllers
{
    public class ContactoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}