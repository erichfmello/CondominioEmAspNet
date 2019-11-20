using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VirtualDoormanAspNet.Models
{
    public class RentalModel
    {
        [Key]
        public string Cnpj { get; set; }
        [Key]
        public string Description { get; set; }

        public double Price { get; set; }

        public ICollection<ResidentialData> ResidentialDatas { get; set; } = new List<ResidentialData>();
        public ICollection<Rental> Rentals { get; set; } = new List<Rental>();

        public RentalModel()
        {
        }

        public RentalModel(string cnpj, string description, double price)
        {
            Cnpj = cnpj;
            Description = description;
            Price = price;
        }

        public void AddResidentialDatas(ResidentialData residentialData)
        {
            ResidentialDatas.Add(residentialData);
        }

        public void RemoveResidentialDatas(ResidentialData residentialData)
        {
            ResidentialDatas.Remove(residentialData);
        }

        public void AddRental(Rental rental)
        {
            Rentals.Add(rental);
        }

        public void RemoveRental(Rental rental)
        {
            Rentals.Remove(rental);
        }
    }
}
