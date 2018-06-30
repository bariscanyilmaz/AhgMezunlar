using Microsoft.EntityFrameworkCore.Migrations;

namespace AhgMezunlar.Migrations
{
    public partial class objectUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Oject",
                table: "Contacts",
                newName: "Object");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Object",
                table: "Contacts",
                newName: "Oject");
        }
    }
}
