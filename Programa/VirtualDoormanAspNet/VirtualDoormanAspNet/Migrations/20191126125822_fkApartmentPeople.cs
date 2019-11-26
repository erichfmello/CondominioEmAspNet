using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualDoormanAspNet.Migrations
{
    public partial class fkApartmentPeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApartmentPeopleApartment",
                table: "Apartment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApartmentPeopleCpf",
                table: "Apartment",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentPeople_Cpf",
                table: "ApartmentPeople",
                column: "Cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_ApartmentPeopleApartment_ApartmentPeopleCpf",
                table: "Apartment",
                columns: new[] { "ApartmentPeopleApartment", "ApartmentPeopleCpf" });

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_ApartmentPeople_ApartmentPeopleApartment_Apartment~",
                table: "Apartment",
                columns: new[] { "ApartmentPeopleApartment", "ApartmentPeopleCpf" },
                principalTable: "ApartmentPeople",
                principalColumns: new[] { "Apartment", "Cpf" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentPeople_People_Cpf",
                table: "ApartmentPeople",
                column: "Cpf",
                principalTable: "People",
                principalColumn: "Cpf",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_ApartmentPeople_ApartmentPeopleApartment_Apartment~",
                table: "Apartment");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentPeople_People_Cpf",
                table: "ApartmentPeople");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentPeople_Cpf",
                table: "ApartmentPeople");

            migrationBuilder.DropIndex(
                name: "IX_Apartment_ApartmentPeopleApartment_ApartmentPeopleCpf",
                table: "Apartment");

            migrationBuilder.DropColumn(
                name: "ApartmentPeopleApartment",
                table: "Apartment");

            migrationBuilder.DropColumn(
                name: "ApartmentPeopleCpf",
                table: "Apartment");
        }
    }
}
