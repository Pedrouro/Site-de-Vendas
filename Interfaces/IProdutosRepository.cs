using SiteDeVendas.Models;

namespace SiteDeVendas.Interfaces
{
    public interface IProdutosRepository
    {
        Task<IEnumerable<ProdutosModel>> GetAll();
        Task<ProdutosModel> GetByIdAsync(int id);
        Task<IEnumerable<ProdutosModel>> GetByTipoAsync(string tipo);
        bool Add(ProdutosModel produto);
        bool Update(ProdutosModel produto);
        bool Delete(ProdutosModel produto);
        bool Save();
    }
}
