using Microsoft.AspNetCore.Mvc;
using SiteDeVendas.Data;
using SiteDeVendas.Interfaces;
using SiteDeVendas.Models;

namespace SiteDeVendas.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutosRepository _produtosRepository;

        public ProdutosController(IProdutosRepository produtosRepository)
        {
            _produtosRepository = produtosRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> VisualizarProdutos(string tipo)
        {
            IEnumerable<ProdutosModel> produtos = await _produtosRepository.GetByTipoAsync(tipo);

            return View(produtos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProdutosModel produto)
        {
            if (!ModelState.IsValid)
            {
                return View(produto);
            }

            _produtosRepository.Add(produto);
            _produtosRepository.Save();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            var produto =  _produtosRepository.GetById(id);

            if(produto == null)
            {
                return Json(new { success = false, message = "Erro ao remover produto." });
            }
            
            _produtosRepository.Delete(produto);
            _produtosRepository.Save();

            return Json(new { success = true, message = "Produto deletado com sucesso." });
        }

        public async Task<IActionResult> Detalhes(int id)
        {
            ProdutosModel produto = await _produtosRepository.GetByIdAsync(id);
            return View(produto);
        }
    }
}
