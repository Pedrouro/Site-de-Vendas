using System.ComponentModel.DataAnnotations;

namespace SiteDeVendas.Models
{
    public class UsuariosModel
    {
        [Key]
        public int UsuarioID { get; set; }
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; } 
        public string? Login { get; set; }
        public string? Senha { get; set; }

    }
}
