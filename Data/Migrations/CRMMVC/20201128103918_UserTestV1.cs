using Microsoft.EntityFrameworkCore.Migrations;

namespace CRMMVC.Migrations.CRMMVC
{
    public partial class UserTestV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Departments_departmentId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Posts_postId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_departmentId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_postId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "postId",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "postId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_departmentId",
                table: "AspNetUsers",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_postId",
                table: "AspNetUsers",
                column: "postId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departments_departmentId",
                table: "AspNetUsers",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Posts_postId",
                table: "AspNetUsers",
                column: "postId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Departments_departmentId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Posts_postId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_departmentId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_postId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "postId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "postId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_departmentId",
                table: "Clients",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_postId",
                table: "Clients",
                column: "postId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Departments_departmentId",
                table: "Clients",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Posts_postId",
                table: "Clients",
                column: "postId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
