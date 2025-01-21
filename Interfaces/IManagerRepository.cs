using SiteDeVendas.Models;

namespace SiteDeVendas.Interfaces
{
    public interface IManagerRepository
    {
        bool CreateProduct(ProdutosModel product);
        bool UpdateProduct(ProdutosModel product);
        bool DeleteProduct(ProdutosModel product);
        bool CreateUser(UsuariosModel user);
        bool UpdateUser(UsuariosModel user);
        bool DeleteUser(UsuariosModel user);
        bool Save();
    }
}
