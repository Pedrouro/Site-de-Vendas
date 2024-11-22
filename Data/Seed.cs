using SiteDeVendas.Models;
using System.Net;

namespace SiteDeVendas.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ProjetoDbContext>();

                context.Database.EnsureCreated();

                if (!context.Produtos.Any())
                {
                    context.Produtos.AddRange(new List<ProdutosModel>()
                    {
                        new ProdutosModel()
                        {
                            ProdutoID = 1,
                            Nome = "PC",
                            Tipo = "Teclogico",
                            Ativo = true,
                            Price = 1000,               
                         },
                        
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
