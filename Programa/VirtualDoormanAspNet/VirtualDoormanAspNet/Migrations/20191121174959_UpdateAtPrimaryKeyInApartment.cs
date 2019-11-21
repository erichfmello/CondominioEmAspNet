using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualDoormanAspNet.Migrations
{
    public partial class UpdateAtPrimaryKeyInApartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rental_Apartment_ApartmentNumber",
                table: "Rental");

            migrationBuilder.DropIndex(
                name: "IX_Rental_ApartmentNumber",
                table: "Rental");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartment",
                table: "Apartment");

            migrationBuilder.AddColumn<string>(
                name: "ApartmentBlock",
                table: "Rental",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Block",
                table: "Apartment",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApartmentNumber",
                table: "Apartment",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartment",
                table: "Apartment",
                columns: new[] { "ApartmentNumber", "Block" });

            migrationBuilder.CreateIndex(
                name: "IX_Rental_ApartmentNumber_ApartmentBlock",
                table: "Rental",
                columns: new[] { "ApartmentNumber", "ApartmentBlock" });

            migrationBuilder.AddForeignKey(
                name: "FK_Rental_Apartment_ApartmentNumber_ApartmentBlock",
                table: "Rental",
                columns: new[] { "ApartmentNumber", "ApartmentBlock" },
                principalTable: "Apartment",
                principalColumns: new[] { "ApartmentNumber", "Block" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rental_Apartment_ApartmentNumber_ApartmentBlock",
                table: "Rental");

            migrationBuilder.DropIndex(
                name: "IX_Rental_ApartmentNumber_ApartmentBlock",
                table: "Rental");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartment",
                table: "Apartment");

            migrationBuilder.DropColumn(
                name: "ApartmentBlock",
                table: "Rental");

            migrationBuilder.AlterColumn<string>(
                name: "Block",
                table: "Apartment",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ApartmentNumber",
                table: "Apartment",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartment",
                table: "Apartment",
                column: "ApartmentNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_ApartmentNumber",
                table: "Rental",
                column: "ApartmentNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Rental_Apartment_ApartmentNumber",
                table: "Rental",
                column: "ApartmentNumber",
                principalTable: "Apartment",
                principalColumn: "ApartmentNumber",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
