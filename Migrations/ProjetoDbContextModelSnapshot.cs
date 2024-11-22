﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiteDeVendas.Data;

#nullable disable

namespace SiteDeVendas.Migrations
{
    [DbContext(typeof(ProjetoDbContext))]
    partial class ProjetoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SiteDeVendas.Models.ItensVendasModel", b =>
                {
                    b.Property<int>("ProdutoID")
                        .HasColumnType("int");

                    b.Property<int>("VendaID")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("ProdutoID", "VendaID");

                    b.HasIndex("VendaID");

                    b.ToTable("ItensVendas");
                });

            modelBuilder.Entity("SiteDeVendas.Models.ProdutosModel", b =>
                {
                    b.Property<int>("ProdutoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdutoID"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProdutoID");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("SiteDeVendas.Models.UsuariosModel", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioID"));

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SiteDeVendas.Models.VendasModel", b =>
                {
                    b.Property<int>("VendaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendaID"));

                    b.Property<bool>("Reembolsado")
                        .HasColumnType("bit");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("VendaID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("SiteDeVendas.Models.ItensVendasModel", b =>
                {
                    b.HasOne("SiteDeVendas.Models.ProdutosModel", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SiteDeVendas.Models.VendasModel", "Venda")
                        .WithMany()
                        .HasForeignKey("VendaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("SiteDeVendas.Models.VendasModel", b =>
                {
                    b.HasOne("SiteDeVendas.Models.UsuariosModel", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
