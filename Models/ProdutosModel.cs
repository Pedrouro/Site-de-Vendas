using System.ComponentModel.DataAnnotations;

namespace SiteDeVendas.Models
{
    public class ProdutosModel
    {
        [Key]
        public int ProdutoID { get; set; }
        public string? Nome { get; set; }
        public string? Tipo { get; set; }
        public int Quantidade { get; set; }
        public bool Ativo { get; set; }
        public float Price { get; set;  }

    }
}
