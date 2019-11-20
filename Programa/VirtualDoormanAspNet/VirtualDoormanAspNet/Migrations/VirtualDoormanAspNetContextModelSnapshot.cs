﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VirtualDoormanAspNet.Models;

namespace VirtualDoormanAspNet.Migrations
{
    [DbContext(typeof(VirtualDoormanAspNetContext))]
    partial class VirtualDoormanAspNetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("VirtualDoormanAspNet.Models.Apartment", b =>
                {
                    b.Property<int>("ApartmentNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Block");

                    b.Property<int>("Final");

                    b.Property<int>("Floor");

                    b.Property<string>("ResidentialDataCnpj");

                    b.HasKey("ApartmentNumber");

                    b.HasIndex("ResidentialDataCnpj");

                    b.ToTable("Apartment");
                });

            modelBuilder.Entity("VirtualDoormanAspNet.Models.ApartmentPeople", b =>
                {
                    b.Property<int>("Apartment");

                    b.Property<string>("Cpf");

                    b.HasKey("Apartment", "Cpf");

                    b.ToTable("ApartmentPeople");
                });

            modelBuilder.Entity("VirtualDoormanAspNet.Models.CommunArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("ResidentialDatasCnpj");

                    b.HasKey("Id");

                    b.HasIndex("ResidentialDatasCnpj");

                    b.ToTable("CommunArea");
                });

            modelBuilder.Entity("VirtualDoormanAspNet.Models.People", b =>
                {
                    b.Property<string>("Cpf")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneDdd");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Rg");

                    b.HasKey("Cpf");

                    b.ToTable("People");
                });

            modelBuilder.Entity("VirtualDoormanAspNet.Models.Rental", b =>
                {
                    b.Property<DateTime>("RentalDate");

                    b.Property<int?>("ApartmentNumber");

                    b.Property<string>("RentalModelCnpj");

                    b.Property<string>("RentalModelDescription");

                    b.HasKey("RentalDate");

                    b.HasIndex("ApartmentNumber");

                    b.HasIndex("RentalModelCnpj", "RentalModelDescription");

                    b.ToTable("Rental");
                });

            modelBuilder.Entity("VirtualDoormanAspNet.Models.RentalModel", b =>
                {
                    b.Property<string>("Cnpj");

                    b.Property<string>("Description");

                    b.Property<double>("Price");

                    b.HasKey("Cnpj", "Description");

                    b.ToTable("RentalModel");
                });

            modelBuilder.Entity("VirtualDoormanAspNet.Models.ResidentialAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Cep");

                    b.Property<string>("Neighborhood");

                    b.Property<string>("Number");

                    b.Property<string>("ResidentialDataCnpj");

                    b.Property<string>("Uf");

                    b.HasKey("Id");

                    b.HasIndex("ResidentialDataCnpj");

                    b.ToTable("ResidentialAddress");
                });

            modelBuilder.Entity("VirtualDoormanAspNet.Models.ResidentialData", b =>
                {
                    b.Property<string>("Cnpj")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApartmentLastFloor");

                    b.Property<int>("ApartmentPerFloor");

                    b.Property<int>("Floor");

                    b.Property<string>("Name");

                    b.Property<int>("NumberBlock");

                    b.Property<string>("RentalModelCnpj");

                    b.Property<string>("RentalModelDescription");

                    b.HasKey("Cnpj");

                    b.HasIndex("RentalModelCnpj", "RentalModelDescription");

                    b.ToTable("ResidentialData");
                });

            modelBuilder.Entity("VirtualDoormanAspNet.Models.Apartment", b =>
                {
                    b.HasOne("VirtualDoormanAspNet.Models.ResidentialData", "ResidentialData")
                        .WithMany("Apartments")
                        .HasForeignKey("ResidentialDataCnpj");
                });

            modelBuilder.Entity("VirtualDoormanAspNet.Models.CommunArea", b =>
                {
                    b.HasOne("VirtualDoormanAspNet.Models.ResidentialData", "ResidentialDatas")
                        .WithMany("CommunAreas")
                        .HasForeignKey("ResidentialDatasCnpj");
                });

            modelBuilder.Entity("VirtualDoormanAspNet.Models.Rental", b =>
                {
                    b.HasOne("VirtualDoormanAspNet.Models.Apartment", "Apartment")
                        .WithMany()
                        .HasForeignKey("ApartmentNumber");

                    b.HasOne("VirtualDoormanAspNet.Models.RentalModel", "RentalModel")
                        .WithMany("Rentals")
                        .HasForeignKey("RentalModelCnpj", "RentalModelDescription");
                });

            modelBuilder.Entity("VirtualDoormanAspNet.Models.ResidentialAddress", b =>
                {
                    b.HasOne("VirtualDoormanAspNet.Models.ResidentialData", "ResidentialData")
                        .WithMany()
                        .HasForeignKey("ResidentialDataCnpj");
                });

            modelBuilder.Entity("VirtualDoormanAspNet.Models.ResidentialData", b =>
                {
                    b.HasOne("VirtualDoormanAspNet.Models.RentalModel")
                        .WithMany("ResidentialDatas")
                        .HasForeignKey("RentalModelCnpj", "RentalModelDescription");
                });
#pragma warning restore 612, 618
        }
    }
}
