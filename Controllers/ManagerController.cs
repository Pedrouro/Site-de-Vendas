using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiteDeVendas.Data;
using SiteDeVendas.Interfaces;
using SiteDeVendas.Models;
using SiteDeVendas.Repository;

namespace SiteDeVendas.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IProdutosRepository _produtosRepository;
        private readonly IManagerRepository _managerRepository;


        public ManagerController(IProdutosRepository produtosRepository, IManagerRepository managerRepository) {

            _managerRepository = managerRepository;
            _produtosRepository = produtosRepository;
        }


        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ManageProducts()
        {
            IEnumerable<ProdutosModel> produtos = await _produtosRepository.GetAll();
            return View(produtos);
        }

        public class Product
        {
            public int id;
            public string name;
            public int quantity;
            public string type;
            public float price;
            public bool active;



        }

        [HttpPost]
        public JsonResult updateProduct([FromBody] ProdutosModel product)
        {

            bool result = _managerRepository.UpdateProduct(product);

            if (result)
            {
                return Json(new
                {

                    //message = $"ID: {product.ProdutoID}     Nome: {product.Nome}        Quantidade: {product.Quantidade}        Type: {product.Tipo}        Price: {product.Price}      Active: {product.Ativo}",
                    message = $"The product has been updated. input: {product.Nome} ",


                });
            }
            else {

                return Json(new
                {
                    //message = $"ID: {product.ProdutoID}     Nome: {product.Nome}        Quantidade: {product.Quantidade}        Type: {product.Tipo}        Price: {product.Price}      Active: {product.Ativo}",
                    message = "ERROR: Something happend and the product can't been updated."
                });
            }
            

        }
    }
}