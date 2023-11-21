﻿// <auto-generated />
using System;
using ComprarJogo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ComprarJogo.Migrations
{
    [DbContext(typeof(CompraDbContext))]
    [Migration("20231119210813_ReembolsoArrumado")]
    partial class ReembolsoArrumado
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ComprarJogo.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ComprarJogo.Models.Compra", b =>
                {
                    b.Property<int>("IdCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCompra"));

                    b.Property<string>("Cupom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataCompra")
                        .HasColumnType("date");

                    b.Property<int>("IdBiblioteca")
                        .HasColumnType("int");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdJogo")
                        .HasColumnType("int");

                    b.Property<int>("IdPagamento")
                        .HasColumnType("int");

                    b.Property<int>("IdReembolso")
                        .HasColumnType("int");

                    b.Property<string>("StatusCompra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Valor")
                        .HasColumnType("float");

                    b.HasKey("IdCompra");

                    b.HasIndex("IdJogo")
                        .IsUnique();

                    b.HasIndex("IdPagamento")
                        .IsUnique();

                    b.HasIndex("IdReembolso")
                        .IsUnique();

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("ComprarJogo.Models.Jogo", b =>
                {
                    b.Property<int>("IdJogo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdJogo"));

                    b.Property<int>("ClassificaoIndicativa")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataLançamento")
                        .HasColumnType("date");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdBiblioteca")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preço")
                        .HasColumnType("float");

                    b.HasKey("IdJogo");

                    b.ToTable("Jogos");
                });

            modelBuilder.Entity("ComprarJogo.Models.Pagamento", b =>
                {
                    b.Property<int>("IdPagamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPagamento"));

                    b.Property<string>("StatusPagamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalPagamento")
                        .HasColumnType("float");

                    b.HasKey("IdPagamento");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("ComprarJogo.Models.Reembolso", b =>
                {
                    b.Property<int>("IdReembolso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReembolso"));

                    b.Property<string>("ChavePix")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdReembolso");

                    b.ToTable("Reembolsos");
                });

            modelBuilder.Entity("ComprarJogo.Models.Compra", b =>
                {
                    b.HasOne("ComprarJogo.Models.Cliente", "Cliente")
                        .WithMany("Compra")
                        .HasForeignKey("IdCompra")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComprarJogo.Models.Jogo", "Jogo")
                        .WithOne("Compra")
                        .HasForeignKey("ComprarJogo.Models.Compra", "IdJogo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComprarJogo.Models.Pagamento", "Pagamento")
                        .WithOne("Compra")
                        .HasForeignKey("ComprarJogo.Models.Compra", "IdPagamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComprarJogo.Models.Reembolso", "Reemboolso")
                        .WithOne("Compra")
                        .HasForeignKey("ComprarJogo.Models.Compra", "IdReembolso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Jogo");

                    b.Navigation("Pagamento");

                    b.Navigation("Reemboolso");
                });

            modelBuilder.Entity("ComprarJogo.Models.Cliente", b =>
                {
                    b.Navigation("Compra");
                });

            modelBuilder.Entity("ComprarJogo.Models.Jogo", b =>
                {
                    b.Navigation("Compra");
                });

            modelBuilder.Entity("ComprarJogo.Models.Pagamento", b =>
                {
                    b.Navigation("Compra");
                });

            modelBuilder.Entity("ComprarJogo.Models.Reembolso", b =>
                {
                    b.Navigation("Compra");
                });
#pragma warning restore 612, 618
        }
    }
}
