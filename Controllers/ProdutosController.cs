﻿using Microsoft.AspNetCore.Mvc;
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


        public async Task<IActionResult> Detalhes(int id)
        {
            ProdutosModel produto = await _produtosRepository.GetByIdAsync(id);
            return View(produto);
        }
    }
}
