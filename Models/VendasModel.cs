using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteDeVendas.Models
{
    public class VendasModel
    {
        [Key]
        public int VendaID { get; set; }
        public int UsuarioID { get; set; }
        [ForeignKey("UsuarioID")]
        public required UsuariosModel Usuario { get; set; }
        public bool Reembolsado { get; set; }
    }
}
