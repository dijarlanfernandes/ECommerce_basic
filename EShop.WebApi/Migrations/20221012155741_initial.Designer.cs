﻿// <auto-generated />
using System;
using EShop.WebApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EShop.WebApi.Migrations
{
    [DbContext(typeof(EShopContext))]
    [Migration("20221012155741_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EShop.WebApi.Entities.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("userid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            id = 1,
                            userid = "1"
                        },
                        new
                        {
                            id = 2,
                            userid = "2"
                        });
                });

            modelBuilder.Entity("EShop.WebApi.Entities.CartIten", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("cartid")
                        .HasColumnType("int");

                    b.Property<int>("productid")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("cartid");

                    b.HasIndex("productid");

                    b.ToTable("CartItens");
                });

            modelBuilder.Entity("EShop.WebApi.Entities.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("iconcss")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            id = 1,
                            iconcss = "fas fa-spa",
                            name = "Beleza"
                        },
                        new
                        {
                            id = 2,
                            iconcss = "fas fa-couch",
                            name = "Moveis"
                        },
                        new
                        {
                            id = 3,
                            iconcss = "fas fa-headphones",
                            name = "Eletronicos"
                        },
                        new
                        {
                            id = 4,
                            iconcss = "fas fa-shoe-prints",
                            name = "Calcados"
                        });
                });

            modelBuilder.Entity("EShop.WebApi.Entities.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("categoryid")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("imgurl")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("price")
                        .HasColumnType("Decimal(10,2)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("categoryid");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            id = 1,
                            categoryid = 1,
                            description = "Um kit fornecido pela Natura, contendo Products para cuidados com a pele",
                            imgurl = "/Imagens/Beleza/Beleza1.png",
                            name = "Glossier - Beleza Kit",
                            price = 100m,
                            quantity = 100
                        },
                        new
                        {
                            id = 2,
                            categoryid = 1,
                            description = "Um kit fornecido pela Curology, contendo Products para cuidados com a pele",
                            imgurl = "/Imagens/Beleza/Beleza2.png",
                            name = "Curology - Kit para Pele",
                            price = 50m,
                            quantity = 45
                        },
                        new
                        {
                            id = 3,
                            categoryid = 1,
                            description = "Um kit fornecido pela Glossier, contendo Products para cuidados com a pele",
                            imgurl = "/Imagens/Beleza/Beleza3.png",
                            name = "Óleo de Coco Orgânico",
                            price = 20m,
                            quantity = 30
                        },
                        new
                        {
                            id = 4,
                            categoryid = 1,
                            description = "Um kit fornecido pela Curology, contendo Products para cuidados com a pele",
                            imgurl = "/Imagens/Beleza/Beleza4.png",
                            name = "Schwarzkopf - Kit de cuidados com a pele e cabelo",
                            price = 50m,
                            quantity = 60
                        },
                        new
                        {
                            id = 5,
                            categoryid = 1,
                            description = "Kit de cuidados com a pele, contendo Products para cuidados com a pele e cabelos",
                            imgurl = "/Imagens/Beleza/Beleza5.png",
                            name = "Kit de cuidados com a pele",
                            price = 30m,
                            quantity = 85
                        },
                        new
                        {
                            id = 6,
                            categoryid = 3,
                            description = "Air Pods - fones de ouvido sem fio intra-auriculares",
                            imgurl = "/Imagens/Eletronicos/eletronico1.png",
                            name = "Fones de ouvidos",
                            price = 100m,
                            quantity = 120
                        },
                        new
                        {
                            id = 7,
                            categoryid = 3,
                            description = "Fones de ouvido dourados na orelha - esses fones de ouvido não são sem fio",
                            imgurl = "/Imagens/Eletronicos/eletronico2.png",
                            name = "Fones de ouvido dourados",
                            price = 40m,
                            quantity = 200
                        },
                        new
                        {
                            id = 8,
                            categoryid = 3,
                            description = "Fones de ouvido pretos na orelha - esses fones de ouvido não são sem fio",
                            imgurl = "/Imagens/Eletronicos/eletronico3.png",
                            name = "Fones de ouvido pretos",
                            price = 40m,
                            quantity = 300
                        },
                        new
                        {
                            id = 9,
                            categoryid = 3,
                            description = "Câmera Digital Sennheiser - Câmera digital de alta qualidade fornecida pela Sennheiser - inclui tripé",
                            imgurl = "/Imagens/Eletronicos/eletronico4.png",
                            name = "Câmera digital Sennheiser com tripé",
                            price = 600m,
                            quantity = 20
                        },
                        new
                        {
                            id = 10,
                            categoryid = 3,
                            description = "Canon Digital Camera - Câmera digital de alta qualidade fornecida pela Canon",
                            imgurl = "/Imagens/Eletronicos/eletronico5.png",
                            name = "Câmera Digital Canon",
                            price = 500m,
                            quantity = 15
                        },
                        new
                        {
                            id = 11,
                            categoryid = 3,
                            description = "Gameboy - Fornecido por Nintendo",
                            imgurl = "/Imagens/Eletronicos/tecnologia6.png",
                            name = "Nintendo Gameboy",
                            price = 100m,
                            quantity = 60
                        },
                        new
                        {
                            id = 12,
                            categoryid = 2,
                            description = "Cadeira de escritório em couro preto muito confortável",
                            imgurl = "/Imagens/Moveis/moveis1.png",
                            name = "Cadeira de escritório de couro preto",
                            price = 50m,
                            quantity = 212
                        },
                        new
                        {
                            id = 13,
                            categoryid = 2,
                            description = "Cadeira de escritório em couro rosa muito confortável",
                            imgurl = "/Imagens/Moveis/moveis2.png",
                            name = "Cadeira de escritório de couro rosa",
                            price = 50m,
                            quantity = 112
                        },
                        new
                        {
                            id = 14,
                            categoryid = 2,
                            description = "Poltrona muito confortável",
                            imgurl = "/Imagens/Moveis/moveis3.png",
                            name = "Espreguiçadeira",
                            price = 70m,
                            quantity = 90
                        },
                        new
                        {
                            id = 15,
                            categoryid = 2,
                            description = "Poltrona prateada muito confortável",
                            imgurl = "/Imagens/Moveis/moveis4.png",
                            name = "Silver Lounge Chair",
                            price = 120m,
                            quantity = 95
                        },
                        new
                        {
                            id = 16,
                            categoryid = 2,
                            description = "Abajur de mesa de porcelana branco e azul",
                            imgurl = "/Imagens/Moveis/moveis6.png",
                            name = "Luminária de mesa de porcelana",
                            price = 15m,
                            quantity = 100
                        },
                        new
                        {
                            id = 17,
                            categoryid = 2,
                            description = "Abajur de mesa de escritório",
                            imgurl = "/Imagens/Moveis/moveis7.png",
                            name = "Office Table Lamp",
                            price = 20m,
                            quantity = 73
                        },
                        new
                        {
                            id = 18,
                            categoryid = 4,
                            description = "Tênis Puma confortáveis na maioria dos tamanhos",
                            imgurl = "/Imagens/Calcados/calcado1.png",
                            name = "Tênis Puma",
                            price = 100m,
                            quantity = 50
                        },
                        new
                        {
                            id = 19,
                            categoryid = 4,
                            description = "Tênis coloridos - disponíveis na maioria dos tamanhos",
                            imgurl = "/Imagens/Calcados/calcado2.png",
                            name = "Tênis Colodiros",
                            price = 150m,
                            quantity = 60
                        },
                        new
                        {
                            id = 20,
                            categoryid = 4,
                            description = "Tênis Nike azul - disponível na maioria dos tamanhos",
                            imgurl = "/Imagens/Calcados/calcado3.png",
                            name = "Tênis Nike Azul",
                            price = 200m,
                            quantity = 70
                        },
                        new
                        {
                            id = 21,
                            categoryid = 4,
                            description = "Treinadores Hummel coloridos - disponíveis na maioria dos tamanhos",
                            imgurl = "/Imagens/Calcados/calcado4.png",
                            name = "Tênis Hummel Coloridos",
                            price = 120m,
                            quantity = 120
                        },
                        new
                        {
                            id = 22,
                            categoryid = 4,
                            description = "Tênis Nike vermelho - disponível na maioria dos tamanhos",
                            imgurl = "/Imagens/Calcados/calcado5.png",
                            name = "Tênis Nike Vermelho",
                            price = 200m,
                            quantity = 100
                        },
                        new
                        {
                            id = 23,
                            categoryid = 4,
                            description = "Sandálias Birkenstock - disponíveis na maioria dos tamanhos",
                            imgurl = "/Imagens/Calcados/calcado6.png",
                            name = "Sandálidas Birkenstock",
                            price = 50m,
                            quantity = 150
                        });
                });

            modelBuilder.Entity("EShop.WebApi.Entities.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("cartid")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("cartid");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            id = 1,
                            username = "Macoratti"
                        },
                        new
                        {
                            id = 2,
                            username = "Janice"
                        });
                });

            modelBuilder.Entity("EShop.WebApi.Entities.CartIten", b =>
                {
                    b.HasOne("EShop.WebApi.Entities.Cart", "cart")
                        .WithMany("cartItens")
                        .HasForeignKey("cartid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EShop.WebApi.Entities.Product", "product")
                        .WithMany("cartItens")
                        .HasForeignKey("productid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cart");

                    b.Navigation("product");
                });

            modelBuilder.Entity("EShop.WebApi.Entities.Product", b =>
                {
                    b.HasOne("EShop.WebApi.Entities.Category", "category")
                        .WithMany("products")
                        .HasForeignKey("categoryid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("EShop.WebApi.Entities.User", b =>
                {
                    b.HasOne("EShop.WebApi.Entities.Cart", "cart")
                        .WithMany()
                        .HasForeignKey("cartid");

                    b.Navigation("cart");
                });

            modelBuilder.Entity("EShop.WebApi.Entities.Cart", b =>
                {
                    b.Navigation("cartItens");
                });

            modelBuilder.Entity("EShop.WebApi.Entities.Category", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("EShop.WebApi.Entities.Product", b =>
                {
                    b.Navigation("cartItens");
                });
#pragma warning restore 612, 618
        }
    }
}
