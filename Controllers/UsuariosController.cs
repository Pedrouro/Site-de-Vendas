using Microsoft.AspNetCore.Mvc;
using SiteDeVendas.Data;
using SiteDeVendas.Interfaces;
using SiteDeVendas.Models;

namespace SiteDeVendas.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuariosRepository _usuariosRepository;
        public UsuariosController(IUsuariosRepository usuariosRepository) {
            _usuariosRepository = usuariosRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ShowUsers()
        {
            IEnumerable<UsuariosModel> users = await _usuariosRepository.GetAll();
            return View(users);
        }
    }
}
