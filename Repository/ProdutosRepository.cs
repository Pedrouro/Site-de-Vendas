using Microsoft.EntityFrameworkCore;
using SiteDeVendas.Data;
using SiteDeVendas.Interfaces;
using SiteDeVendas.Models;

namespace SiteDeVendas.Repository
{
    public class ProdutosRepository : IProdutosRepository
    {
        private readonly ProjetoDbContext _context;
        public ProdutosRepository(ProjetoDbContext context) { 
            
            _context = context;

        }

        public bool Add(ProdutosModel produto)
        {
            _context.Add(produto);
            return Save();
        }

        public bool Delete(ProdutosModel produto)
        {
            _context.Remove(produto);
            return Save();
        }

        public async Task<IEnumerable<ProdutosModel>> GetAll()
        {
            return await _context.Produtos.ToListAsync();

        }
        
        public async Task<ProdutosModel> GetByIdAsync(int id)
        {
            return await _context.Produtos.FirstOrDefaultAsync(x => x.ProdutoID == id);
        }

        public ProdutosModel GetById(int id)
        {
            return _context.Produtos.FirstOrDefault(x => x.ProdutoID == id);
        }

        public async Task<IEnumerable<ProdutosModel>> GetByTipoAsync(string tipo)
        {
            return await _context.Produtos.Where(x => x.Tipo.Contains(tipo)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(ProdutosModel produto)
        {
            _context.Update(produto);
            return Save();
        }
    }
}
