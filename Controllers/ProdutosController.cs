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
            return View();
        }

        public IActionResult VisualizarProdutos(string tipo)
        {
            var produtos = _context.Produtos.
                Where(x => x.Tipo == tipo).ToList();

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

        public IActionResult Detalhes(int id)
        {
            var item = _context.Produtos.FirstOrDefault(x => x.ProdutoID == id);
            return View(item);
        }
    }
}
