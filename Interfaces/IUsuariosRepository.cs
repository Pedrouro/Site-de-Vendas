using Microsoft.AspNetCore.Mvc;
using SiteDeVendas.Data;
using SiteDeVendas.Models;

namespace SiteDeVendas.Interfaces
{
    public interface IUsuariosRepository 
    {
        public Task<IEnumerable<UsuariosModel>> GetAll();
        public Task<UsuariosModel> GetUserByID(int id);
        public Task<UsuariosModel> GetUserByName(string name);
        public bool Add(UsuariosModel user);
        public bool Update(UsuariosModel user);
        public bool Delete(UsuariosModel user);
        public bool Save();
    }
}
