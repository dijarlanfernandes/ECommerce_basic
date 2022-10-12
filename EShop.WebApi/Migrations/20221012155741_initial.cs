using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.WebApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    iconcss = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cartid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_Carts_cartid",
                        column: x => x.cartid,
                        principalTable: "Carts",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    imgurl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    price = table.Column<decimal>(type: "Decimal(10,2)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    categoryid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                    table.ForeignKey(
                        name: "FK_products_Category_categoryid",
                        column: x => x.categoryid,
                        principalTable: "Category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItens",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cartid = table.Column<int>(type: "int", nullable: false),
                    productid = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItens", x => x.id);
                    table.ForeignKey(
                        name: "FK_CartItens_Carts_cartid",
                        column: x => x.cartid,
                        principalTable: "Carts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItens_products_productid",
                        column: x => x.productid,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "id", "userid" },
                values: new object[,]
                {
                    { 1, "1" },
                    { 2, "2" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "id", "iconcss", "name" },
                values: new object[,]
                {
                    { 1, "fas fa-spa", "Beleza" },
                    { 2, "fas fa-couch", "Moveis" },
                    { 3, "fas fa-headphones", "Eletronicos" },
                    { 4, "fas fa-shoe-prints", "Calcados" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "cartid", "password", "username" },
                values: new object[,]
                {
                    { 1, null, null, "Macoratti" },
                    { 2, null, null, "Janice" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "categoryid", "description", "imgurl", "name", "price", "quantity" },
                values: new object[,]
                {
                    { 1, 1, "Um kit fornecido pela Natura, contendo Products para cuidados com a pele", "/Imagens/Beleza/Beleza1.png", "Glossier - Beleza Kit", 100m, 100 },
                    { 2, 1, "Um kit fornecido pela Curology, contendo Products para cuidados com a pele", "/Imagens/Beleza/Beleza2.png", "Curology - Kit para Pele", 50m, 45 },
                    { 3, 1, "Um kit fornecido pela Glossier, contendo Products para cuidados com a pele", "/Imagens/Beleza/Beleza3.png", "Óleo de Coco Orgânico", 20m, 30 },
                    { 4, 1, "Um kit fornecido pela Curology, contendo Products para cuidados com a pele", "/Imagens/Beleza/Beleza4.png", "Schwarzkopf - Kit de cuidados com a pele e cabelo", 50m, 60 },
                    { 5, 1, "Kit de cuidados com a pele, contendo Products para cuidados com a pele e cabelos", "/Imagens/Beleza/Beleza5.png", "Kit de cuidados com a pele", 30m, 85 },
                    { 6, 3, "Air Pods - fones de ouvido sem fio intra-auriculares", "/Imagens/Eletronicos/eletronico1.png", "Fones de ouvidos", 100m, 120 },
                    { 7, 3, "Fones de ouvido dourados na orelha - esses fones de ouvido não são sem fio", "/Imagens/Eletronicos/eletronico2.png", "Fones de ouvido dourados", 40m, 200 },
                    { 8, 3, "Fones de ouvido pretos na orelha - esses fones de ouvido não são sem fio", "/Imagens/Eletronicos/eletronico3.png", "Fones de ouvido pretos", 40m, 300 },
                    { 9, 3, "Câmera Digital Sennheiser - Câmera digital de alta qualidade fornecida pela Sennheiser - inclui tripé", "/Imagens/Eletronicos/eletronico4.png", "Câmera digital Sennheiser com tripé", 600m, 20 },
                    { 10, 3, "Canon Digital Camera - Câmera digital de alta qualidade fornecida pela Canon", "/Imagens/Eletronicos/eletronico5.png", "Câmera Digital Canon", 500m, 15 },
                    { 11, 3, "Gameboy - Fornecido por Nintendo", "/Imagens/Eletronicos/tecnologia6.png", "Nintendo Gameboy", 100m, 60 },
                    { 12, 2, "Cadeira de escritório em couro preto muito confortável", "/Imagens/Moveis/moveis1.png", "Cadeira de escritório de couro preto", 50m, 212 },
                    { 13, 2, "Cadeira de escritório em couro rosa muito confortável", "/Imagens/Moveis/moveis2.png", "Cadeira de escritório de couro rosa", 50m, 112 },
                    { 14, 2, "Poltrona muito confortável", "/Imagens/Moveis/moveis3.png", "Espreguiçadeira", 70m, 90 },
                    { 15, 2, "Poltrona prateada muito confortável", "/Imagens/Moveis/moveis4.png", "Silver Lounge Chair", 120m, 95 },
                    { 16, 2, "Abajur de mesa de porcelana branco e azul", "/Imagens/Moveis/moveis6.png", "Luminária de mesa de porcelana", 15m, 100 },
                    { 17, 2, "Abajur de mesa de escritório", "/Imagens/Moveis/moveis7.png", "Office Table Lamp", 20m, 73 },
                    { 18, 4, "Tênis Puma confortáveis na maioria dos tamanhos", "/Imagens/Calcados/calcado1.png", "Tênis Puma", 100m, 50 },
                    { 19, 4, "Tênis coloridos - disponíveis na maioria dos tamanhos", "/Imagens/Calcados/calcado2.png", "Tênis Colodiros", 150m, 60 },
                    { 20, 4, "Tênis Nike azul - disponível na maioria dos tamanhos", "/Imagens/Calcados/calcado3.png", "Tênis Nike Azul", 200m, 70 },
                    { 21, 4, "Treinadores Hummel coloridos - disponíveis na maioria dos tamanhos", "/Imagens/Calcados/calcado4.png", "Tênis Hummel Coloridos", 120m, 120 },
                    { 22, 4, "Tênis Nike vermelho - disponível na maioria dos tamanhos", "/Imagens/Calcados/calcado5.png", "Tênis Nike Vermelho", 200m, 100 },
                    { 23, 4, "Sandálias Birkenstock - disponíveis na maioria dos tamanhos", "/Imagens/Calcados/calcado6.png", "Sandálidas Birkenstock", 50m, 150 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItens_cartid",
                table: "CartItens",
                column: "cartid");

            migrationBuilder.CreateIndex(
                name: "IX_CartItens_productid",
                table: "CartItens",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_products_categoryid",
                table: "products",
                column: "categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_cartid",
                table: "Users",
                column: "cartid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItens");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
