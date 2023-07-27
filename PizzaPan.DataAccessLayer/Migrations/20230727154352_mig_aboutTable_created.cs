using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaPan.DataAccessLayer.Migrations
{
    public partial class mig_aboutTable_created : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field1Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field1ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field2Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field2ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field3Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field3ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field4Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Field4ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");
        }
    }
}
