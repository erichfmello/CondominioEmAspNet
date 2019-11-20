using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualDoormanAspNet.Migrations
{
    public partial class OthersEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApartmentLastFloor",
                table: "ResidentialData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ApartmentPerFloor",
                table: "ResidentialData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Floor",
                table: "ResidentialData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberBlock",
                table: "ResidentialData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RentalModelCnpj",
                table: "ResidentialData",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RentalModelDescription",
                table: "ResidentialData",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Apartment",
                columns: table => new
                {
                    ApartmentNumber = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Floor = table.Column<int>(nullable: false),
                    Final = table.Column<int>(nullable: false),
                    Block = table.Column<string>(nullable: true),
                    ResidentialDataCnpj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment", x => x.ApartmentNumber);
                    table.ForeignKey(
                        name: "FK_Apartment_ResidentialData_ResidentialDataCnpj",
                        column: x => x.ResidentialDataCnpj,
                        principalTable: "ResidentialData",
                        principalColumn: "Cnpj",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApartmentPeople",
                columns: table => new
                {
                    Apartment = table.Column<int>(nullable: false),
                    Cpf = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentPeople", x => new { x.Apartment, x.Cpf });
                });

            migrationBuilder.CreateTable(
                name: "CommunArea",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ResidentialDatasCnpj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunArea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommunArea_ResidentialData_ResidentialDatasCnpj",
                        column: x => x.ResidentialDatasCnpj,
                        principalTable: "ResidentialData",
                        principalColumn: "Cnpj",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Cpf = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    PhoneDdd = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Cpf);
                });

            migrationBuilder.CreateTable(
                name: "RentalModel",
                columns: table => new
                {
                    Cnpj = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalModel", x => new { x.Cnpj, x.Description });
                });

            migrationBuilder.CreateTable(
                name: "ResidentialAddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Neighborhood = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    ResidentialDataCnpj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidentialAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResidentialAddress_ResidentialData_ResidentialDataCnpj",
                        column: x => x.ResidentialDataCnpj,
                        principalTable: "ResidentialData",
                        principalColumn: "Cnpj",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rental",
                columns: table => new
                {
                    RentalDate = table.Column<DateTime>(nullable: false),
                    RentalModelCnpj = table.Column<string>(nullable: true),
                    RentalModelDescription = table.Column<string>(nullable: true),
                    ApartmentNumber = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental", x => x.RentalDate);
                    table.ForeignKey(
                        name: "FK_Rental_Apartment_ApartmentNumber",
                        column: x => x.ApartmentNumber,
                        principalTable: "Apartment",
                        principalColumn: "ApartmentNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rental_RentalModel_RentalModelCnpj_RentalModelDescription",
                        columns: x => new { x.RentalModelCnpj, x.RentalModelDescription },
                        principalTable: "RentalModel",
                        principalColumns: new[] { "Cnpj", "Description" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResidentialData_RentalModelCnpj_RentalModelDescription",
                table: "ResidentialData",
                columns: new[] { "RentalModelCnpj", "RentalModelDescription" });

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_ResidentialDataCnpj",
                table: "Apartment",
                column: "ResidentialDataCnpj");

            migrationBuilder.CreateIndex(
                name: "IX_CommunArea_ResidentialDatasCnpj",
                table: "CommunArea",
                column: "ResidentialDatasCnpj");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_ApartmentNumber",
                table: "Rental",
                column: "ApartmentNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Rental_RentalModelCnpj_RentalModelDescription",
                table: "Rental",
                columns: new[] { "RentalModelCnpj", "RentalModelDescription" });

            migrationBuilder.CreateIndex(
                name: "IX_ResidentialAddress_ResidentialDataCnpj",
                table: "ResidentialAddress",
                column: "ResidentialDataCnpj");

            migrationBuilder.AddForeignKey(
                name: "FK_ResidentialData_RentalModel_RentalModelCnpj_RentalModelDescr~",
                table: "ResidentialData",
                columns: new[] { "RentalModelCnpj", "RentalModelDescription" },
                principalTable: "RentalModel",
                principalColumns: new[] { "Cnpj", "Description" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResidentialData_RentalModel_RentalModelCnpj_RentalModelDescr~",
                table: "ResidentialData");

            migrationBuilder.DropTable(
                name: "ApartmentPeople");

            migrationBuilder.DropTable(
                name: "CommunArea");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Rental");

            migrationBuilder.DropTable(
                name: "ResidentialAddress");

            migrationBuilder.DropTable(
                name: "Apartment");

            migrationBuilder.DropTable(
                name: "RentalModel");

            migrationBuilder.DropIndex(
                name: "IX_ResidentialData_RentalModelCnpj_RentalModelDescription",
                table: "ResidentialData");

            migrationBuilder.DropColumn(
                name: "ApartmentLastFloor",
                table: "ResidentialData");

            migrationBuilder.DropColumn(
                name: "ApartmentPerFloor",
                table: "ResidentialData");

            migrationBuilder.DropColumn(
                name: "Floor",
                table: "ResidentialData");

            migrationBuilder.DropColumn(
                name: "NumberBlock",
                table: "ResidentialData");

            migrationBuilder.DropColumn(
                name: "RentalModelCnpj",
                table: "ResidentialData");

            migrationBuilder.DropColumn(
                name: "RentalModelDescription",
                table: "ResidentialData");
        }
    }
}
