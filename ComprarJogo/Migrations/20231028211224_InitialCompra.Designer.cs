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
    [Migration("20231028211224_InitialCompra")]
    partial class InitialCompra
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
                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DataNascimento")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("CPF");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ComprarJogo.Models.Compra", b =>
                {
                    b.Property<int>("IdCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCompra"));

                    b.Property<string>("ClienteCPF")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DataCompra")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("IdJogo")
                        .HasColumnType("int");

                    b.Property<int?>("JogoIdJogo")
                        .HasColumnType("int");

                    b.Property<double?>("Valor")
                        .IsRequired()
                        .HasColumnType("float");

                    b.HasKey("IdCompra");

                    b.HasIndex("ClienteCPF");

                    b.HasIndex("JogoIdJogo");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("ComprarJogo.Models.Jogo", b =>
                {
                    b.Property<int>("IdJogo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdJogo"));

                    b.Property<int>("ClassificaoIndicativa")
                        .HasMaxLength(250)
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataLançamento")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preço")
                        .HasMaxLength(250)
                        .HasColumnType("float");

                    b.HasKey("IdJogo");

                    b.ToTable("Jogos");
                });

            modelBuilder.Entity("ComprarJogo.Models.Compra", b =>
                {
                    b.HasOne("ComprarJogo.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteCPF");

                    b.HasOne("ComprarJogo.Models.Jogo", "Jogo")
                        .WithMany()
                        .HasForeignKey("JogoIdJogo");

                    b.Navigation("Cliente");

                    b.Navigation("Jogo");
                });
#pragma warning restore 612, 618
        }
    }
}
