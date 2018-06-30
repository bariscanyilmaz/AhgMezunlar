using Microsoft.EntityFrameworkCore.Migrations;

namespace AhgMezunlar.Migrations
{
    public partial class IsRead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReadIt",
                table: "Contacts",
                newName: "IsRead");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsRead",
                table: "Contacts",
                newName: "ReadIt");
        }
    }
}
