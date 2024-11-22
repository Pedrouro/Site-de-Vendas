using Microsoft.EntityFrameworkCore;
using SiteDeVendas.Models;

namespace SiteDeVendas.Data
{
    public class ProjetoDbContext : DbContext
    {
        public ProjetoDbContext(DbContextOptions<ProjetoDbContext> options) : base(options)
        {
            
        }
        public DbSet<ProdutosModel> Produtos { get; set; }
        public DbSet<UsuariosModel> Usuarios { get; set; }
        public DbSet<VendasModel> Vendas { get; set; }
        public DbSet<ItensVendasModel> ItensVendas { get; set; }

        // O codigo abaixo serve para dizer que os campos "ProdutoID" e "VendaID" formaram uma chave composta.
        // Coloquei isto para realizar a primeira migration do projeto com o comando "Add-Migration InitialCreate"
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItensVendasModel>()
                .HasKey(iv => new { iv.ProdutoID, iv.VendaID });
        }
    }
}
