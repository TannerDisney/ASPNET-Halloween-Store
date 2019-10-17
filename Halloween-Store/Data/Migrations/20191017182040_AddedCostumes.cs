using Microsoft.EntityFrameworkCore.Migrations;

namespace Halloween_Store.Data.Migrations
{
    public partial class AddedCostumes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Costumes",
                columns: table => new
                {
                    CostumeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostumeName = table.Column<string>(maxLength: 50, nullable: false),
                    Size = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 150, nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costumes", x => x.CostumeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Costumes");
        }
    }
}
