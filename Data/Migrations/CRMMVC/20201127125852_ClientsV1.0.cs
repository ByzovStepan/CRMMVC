using Microsoft.EntityFrameworkCore.Migrations;

namespace CRMMVC.Migrations.CRMMVC
{
    public partial class ClientsV10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(nullable: false),
                    second_name = table.Column<string>(nullable: false),
                    middle_name = table.Column<string>(nullable: true),
                    phone_number = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    gender = table.Column<string>(maxLength: 7, nullable: true),
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
