using Microsoft.AspNetCore.Mvc;
using SiteDeVendas.Data;

namespace SiteDeVendas.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProjetoDbContext _context;

        public ProdutosController(ProjetoDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var produtos = _context.Produtos.ToList();
            return View(produtos);
        }

        public IActionResult Comidas()
        {
            var produtos = _context.Produtos.
                Where(u => u.Tipo == "Comida")
                .ToList();

            return View(produtos);
        }

        public IActionResult Tech()
        {
            var produtos = _context.Produtos.
                Where(x => x.Tipo == "Tech" && x.Ativo == true).ToList();
            return View(produtos);
        }
    }
}
