using Microsoft.EntityFrameworkCore.Migrations;

namespace TransIstanbul.Migrations
{
    public partial class Istanbul_Db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlueCard",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    Points = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueCard", x => x.CardId);
                });

            migrationBuilder.CreateTable(
                name: "ElectronicCard",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false),
                    PriceOfCard = table.Column<double>(type: "float", nullable: true),
                    Points = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectronicCard", x => x.CardId);
                });

            migrationBuilder.CreateTable(
                name: "IstanbulCard",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false),
                    CustomerType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    Balance = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IstanbulCard", x => x.CardId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlueCard");

            migrationBuilder.DropTable(
                name: "ElectronicCard");

            migrationBuilder.DropTable(
                name: "IstanbulCard");
        }
    }
}
