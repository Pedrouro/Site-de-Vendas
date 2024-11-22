using Microsoft.AspNetCore.Mvc;

namespace SiteDeVendas.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
