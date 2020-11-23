using Microsoft.EntityFrameworkCore.Migrations;

namespace CRMMVC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(nullable: true),
                    second_name = table.Column<string>(nullable: true),
                    middle_name = table.Column<string>(nullable: true),
                    phone_number = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    age = table.Column<int>(nullable: true),
                    note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
