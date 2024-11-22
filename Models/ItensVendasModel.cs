using System.ComponentModel.DataAnnotations.Schema;

namespace SiteDeVendas.Models
{
    public class ItensVendasModel
    {
        [ForeignKey("ProdutoID")]
        public int ProdutoID { get; set; }

        public required ProdutosModel Produto { get; set; }

        [ForeignKey("VendaID")]
        public int VendaID { get; set; }

        public required VendasModel Venda { get; set; }

        public int Quantidade { get; set; }

    }
}
