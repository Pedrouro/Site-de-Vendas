using SiteDeVendas.Data;
using SiteDeVendas.Interfaces;
using SiteDeVendas.Models;

namespace SiteDeVendas.Repository
{
    public class ManagerRepository : IManagerRepository
    {
        public readonly ProjetoDbContext _context;
        public ManagerRepository(ProjetoDbContext context) {
        
            _context = context;
        }
        public bool CreateProduct(ProdutosModel product)
        {
            _context.Produtos.Add(product);
            return Save();
        }

        public bool UpdateProduct(ProdutosModel product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            _context.Produtos.Update(product);
            return Save();
        }

        public bool DeleteProduct(ProdutosModel product)
        {
            _context.Produtos.Remove(product);
            return Save();
        }

        public bool CreateUser(UsuariosModel user)
        {
            _context.Usuarios.Add(user);
            return Save();
        }

        public bool UpdateUser(UsuariosModel user)
        {
            _context.Usuarios.Update(user);
            return Save();
        }
        public bool DeleteUser(UsuariosModel user)
        {
            _context.Usuarios.Remove(user);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved >= 1 ?  true :  false;
        }


    }
}
