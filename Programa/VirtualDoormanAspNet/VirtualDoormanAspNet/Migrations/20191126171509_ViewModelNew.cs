using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualDoormanAspNet.Migrations
{
    public partial class ViewModelNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApartmentNumber",
                table: "People",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApartmentNumber",
                table: "People");
        }
    }
}
