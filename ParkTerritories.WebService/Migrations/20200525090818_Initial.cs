using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkTerritories.WebService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Location = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Water = table.Column<string>(nullable: true),
                    PlayGround = table.Column<string>(nullable: true),
                    SportsGround = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 1L, "Главный вход в парк расположен со стороны улицы Косыгина, рельеф местности спокойный, резкопересечённый, с перепадом высот до 30 м, площадки и дорожки выложены плиткой и асфальтом, за корпусами расположен парк с многолетними деревьями", "Памятник садово-паркового искусства – «Парк Дворца творчества детей и юношества» по адресу ул.Косыгина д.17", "нет", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 2L, "улица Большая Филёвская, дом 9", "Детский парк «Фили»", "да", "нет", "нет" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Location", "Name", "PlayGround", "SportsGround", "Water" },
                values: new object[] { 3L, "Восточная часть района Ясенево", "Природно-исторический парк «Битцевский лес»", "нет", "да", "нет" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
