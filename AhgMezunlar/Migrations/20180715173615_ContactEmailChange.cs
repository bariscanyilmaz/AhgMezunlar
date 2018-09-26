using Microsoft.EntityFrameworkCore.Migrations;

namespace AhgMezunlar.Migrations
{
    public partial class ContactEmailChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Contacts",
                newName: "ContactEmail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactEmail",
                table: "Contacts",
                newName: "Email");
        }
    }
}
