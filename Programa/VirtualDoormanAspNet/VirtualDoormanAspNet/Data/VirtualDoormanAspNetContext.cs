using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VirtualDoormanAspNet.Models
{
    public class VirtualDoormanAspNetContext : DbContext
    {
        public VirtualDoormanAspNetContext(DbContextOptions<VirtualDoormanAspNetContext> options)
            : base(options)
        {
        }

        public DbSet<Apartment> Apartment { get; set; }
        public DbSet<ApartmentPeople> ApartmentPeople { get; set; }
        public DbSet<CommunArea> CommunArea { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Rental> Rental { get; set; }
        public DbSet<RentalModel> RentalModel { get; set; }
        public DbSet<ResidentialAddress> ResidentialAddress { get; set; }
        public DbSet<ResidentialData> ResidentialData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RentalModel>().HasKey(c => new { c.Cnpj, c.Description });
            modelBuilder.Entity<ApartmentPeople>().HasKey(c => new { c.Apartment, c.Cpf });
        }
    }
}