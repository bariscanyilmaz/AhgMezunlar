using Microsoft.EntityFrameworkCore.Migrations;

namespace AhgMezunlar.Migrations
{
    public partial class AddedReadIt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ReadIt",
                table: "Contacts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReadIt",
                table: "Contacts");
        }
    }
}
