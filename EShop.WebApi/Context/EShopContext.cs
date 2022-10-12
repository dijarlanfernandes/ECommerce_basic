using EShop.WebApi.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace EShop.WebApi.Context
{
    public class EShopContext:DbContext
    {
        public EShopContext(DbContextOptions<EShopContext> options):base(options){}
        public DbSet<Product> products { get; set; }
        public DbSet<CartIten> CartItens { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.Entity<Product>().HasData(new Product
            {
                id = 1,
                name = "Glossier - Beleza Kit",
                description = "Um kit fornecido pela Natura, contendo Products para cuidados com a pele",
                imgurl = "/Imagens/Beleza/Beleza1.png",
                price = 100,
                quantity = 100,
                categoryid = 1

            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 2,
                name = "Curology - Kit para Pele",
                description = "Um kit fornecido pela Curology, contendo Products para cuidados com a pele",
                imgurl = "/Imagens/Beleza/Beleza2.png",
                price = 50,
                quantity = 45,
                categoryid = 1

            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 3,
                name = "Óleo de Coco Orgânico",
                description = "Um kit fornecido pela Glossier, contendo Products para cuidados com a pele",
                imgurl = "/Imagens/Beleza/Beleza3.png",
                price = 20,
                quantity = 30,
                categoryid = 1

            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 4,
                name = "Schwarzkopf - Kit de cuidados com a pele e cabelo",
                description = "Um kit fornecido pela Curology, contendo Products para cuidados com a pele",
                imgurl = "/Imagens/Beleza/Beleza4.png",
                price = 50,
                quantity = 60,
                categoryid = 1

            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 5,
                name = "Kit de cuidados com a pele",
                description = "Kit de cuidados com a pele, contendo Products para cuidados com a pele e cabelos",
                imgurl = "/Imagens/Beleza/Beleza5.png",
                price = 30,
                quantity = 85,
                categoryid = 1

            });
            //eletronico Category
            builder.Entity<Product>().HasData(new Product
            {
                id = 6,
                name = "Fones de ouvidos",
                description = "Air Pods - fones de ouvido sem fio intra-auriculares",
                imgurl = "/Imagens/Eletronicos/eletronico1.png",
                price = 100,
                quantity = 120,
                categoryid = 3

            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 7,
                name = "Fones de ouvido dourados",
                description = "Fones de ouvido dourados na orelha - esses fones de ouvido não são sem fio",
                imgurl = "/Imagens/Eletronicos/eletronico2.png",
                price = 40,
                quantity = 200,
                categoryid = 3

            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 8,
                name = "Fones de ouvido pretos",
                description = "Fones de ouvido pretos na orelha - esses fones de ouvido não são sem fio",
                imgurl = "/Imagens/Eletronicos/eletronico3.png",
                price = 40,
                quantity = 300,
                categoryid = 3

            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 9,
                name = "Câmera digital Sennheiser com tripé",
                description = "Câmera Digital Sennheiser - Câmera digital de alta qualidade fornecida pela Sennheiser - inclui tripé",
                imgurl = "/Imagens/Eletronicos/eletronico4.png",
                price = 600,
                quantity = 20,
                categoryid = 3

            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 10,
                name = "Câmera Digital Canon",
                description = "Canon Digital Camera - Câmera digital de alta qualidade fornecida pela Canon",
                imgurl = "/Imagens/Eletronicos/eletronico5.png",
                price = 500,
                quantity = 15,
                categoryid = 3

            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 11,
                name = "Nintendo Gameboy",
                description = "Gameboy - Fornecido por Nintendo",
                imgurl = "/Imagens/Eletronicos/tecnologia6.png",
                price = 100,
                quantity = 60,
                categoryid = 3
            });
            //Moveis Category
            builder.Entity<Product>().HasData(new Product
            {
                id = 12,
                name = "Cadeira de escritório de couro preto",
                description = "Cadeira de escritório em couro preto muito confortável",
                imgurl = "/Imagens/Moveis/moveis1.png",
                price = 50,
                quantity = 212,
                categoryid = 2
            });

            builder.Entity<Product>().HasData(new Product
            {
                id = 13,
                name = "Cadeira de escritório de couro rosa",
                description = "Cadeira de escritório em couro rosa muito confortável",
                imgurl = "/Imagens/Moveis/moveis2.png",
                price = 50,
                quantity = 112,
                categoryid = 2
            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 14,
                name = "Espreguiçadeira",
                description = "Poltrona muito confortável",
                imgurl = "/Imagens/Moveis/moveis3.png",
                price = 70,
                quantity = 90,
                categoryid = 2
            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 15,
                name = "Silver Lounge Chair",
                description = "Poltrona prateada muito confortável",
                imgurl = "/Imagens/Moveis/moveis4.png",
                price = 120,
                quantity = 95,
                categoryid = 2
            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 16,
                name = "Luminária de mesa de porcelana",
                description = "Abajur de mesa de porcelana branco e azul",
                imgurl = "/Imagens/Moveis/moveis6.png",
                price = 15,
                quantity = 100,
                categoryid = 2
            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 17,
                name = "Office Table Lamp",
                description = "Abajur de mesa de escritório",
                imgurl = "/Imagens/Moveis/moveis7.png",
                price = 20,
                quantity = 73,
                categoryid = 2
            });
            //Calcados Category
            builder.Entity<Product>().HasData(new Product
            {
                id = 18,
                name = "Tênis Puma",
                description = "Tênis Puma confortáveis na maioria dos tamanhos",
                imgurl = "/Imagens/Calcados/calcado1.png",
                price = 100,
                quantity = 50,
                categoryid = 4
            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 19,
                name = "Tênis Colodiros",
                description = "Tênis coloridos - disponíveis na maioria dos tamanhos",
                imgurl = "/Imagens/Calcados/calcado2.png",
                price = 150,
                quantity = 60,
                categoryid = 4
            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 20,
                name = "Tênis Nike Azul",
                description = "Tênis Nike azul - disponível na maioria dos tamanhos",
                imgurl = "/Imagens/Calcados/calcado3.png",
                price = 200,
                quantity = 70,
                categoryid = 4
            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 21,
                name = "Tênis Hummel Coloridos",
                description = "Treinadores Hummel coloridos - disponíveis na maioria dos tamanhos",
                imgurl = "/Imagens/Calcados/calcado4.png",
                price = 120,
                quantity = 120,
                categoryid = 4
            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 22,
                name = "Tênis Nike Vermelho",
                description = "Tênis Nike vermelho - disponível na maioria dos tamanhos",
                imgurl = "/Imagens/Calcados/calcado5.png",
                price = 200,
                quantity = 100,
                categoryid = 4
            });
            builder.Entity<Product>().HasData(new Product
            {
                id = 23,
                name = "Sandálidas Birkenstock",
                description = "Sandálias Birkenstock - disponíveis na maioria dos tamanhos",
                imgurl = "/Imagens/Calcados/calcado6.png",
                price = 50,
                quantity = 150,
                categoryid = 4
            });

            //Add users
            builder.Entity<User>().HasData(new User
            {
                id = 1,
                username = "Macoratti"

            });
            builder.Entity<User>().HasData(new User
            {
                id = 2,
                username = "Janice"

            });

            //Create Shopping Carrinho for Users
            builder.Entity<Cart>().HasData(new Cart
            {
                id = 1,
                userid = "1"

            });
            builder.Entity<Cart>().HasData(new Cart
            {
                id = 2,
                userid = "2"

            });
            //Add Product Categories
            builder.Entity<Category>().HasData(new Category
            {
                id = 1,
                name = "Beleza",
                iconcss = "fas fa-spa"
            });
            builder.Entity<Category>().HasData(new Category
            {
                id = 2,
                name = "Moveis",
                iconcss = "fas fa-couch"
            });
            builder.Entity<Category>().HasData(new Category
            {
                id = 3,
                name = "Eletronicos",
                iconcss = "fas fa-headphones"
            });
            builder.Entity<Category>().HasData(new Category
            {
                id = 4,
                name = "Calcados",
                iconcss = "fas fa-shoe-prints"
            });


        }
    }
}
