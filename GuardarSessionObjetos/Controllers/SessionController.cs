using Microsoft.AspNetCore.Mvc;

namespace GuardarSessionObjetos.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
