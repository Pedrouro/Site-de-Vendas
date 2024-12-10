using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiteDeVendas.Data;
using SiteDeVendas.Interfaces;
using SiteDeVendas.Models;

namespace SiteDeVendas.Repository
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly ProjetoDbContext _context;
        public UsuariosRepository(ProjetoDbContext context)
        {
            _context = context;
        }

        public async Task<UsuariosModel> GetUserByID(int id)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.UsuarioID == id);
        }

        public async Task<UsuariosModel> GetUserByName(string name)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.Nome == name);
        }

        public async Task<IEnumerable<UsuariosModel>> GetAll()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public bool Add(UsuariosModel user)
        {
            _context.Add(user);
            return Save();
        }

        public bool Delete(UsuariosModel user)
        {
            _context.Remove(user);
            return Save();
        }

        public bool Update(UsuariosModel user)
        {
            _context.Update(user);
            return Save();
        }

        public bool Save()
        {
            int saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
