using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace VirtualDoormanAspNet.Models
{
    public class ResidentialData
    {
        [Key]
        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; }

        [Display(Name = "Nome do Condomínio")]
        public string Name { get; set; }

        [Display(Name = "Apartamentos no último andar")]
        public int ApartmentLastFloor { get; set; }

        [Display(Name = "Número de andares")]
        public int Floor { get; set; }

        [Display(Name = "Apartamentos por andar")]
        public int ApartmentPerFloor { get; set; }

        [Display(Name = "Número de blocos")]
        public int NumberBlock { get; set; }

        public ICollection<Apartment> Apartments { get; set; } = new List<Apartment>();
        public ICollection<CommunArea> CommunAreas { get; set; } = new List<CommunArea>();

        public ResidentialData()
        {
        }

        public ResidentialData(string cnpj, string name, int apartmentLastFloor, int floor, int apartmentPerFloor, int numberBlock)
        {
            Cnpj = cnpj;
            Name = name;
            ApartmentLastFloor = apartmentLastFloor;
            Floor = floor;
            ApartmentPerFloor = apartmentPerFloor;
            NumberBlock = numberBlock;
        }

        public void AddApartment(Apartment apartment)
        {
            Apartments.Add(apartment);
        }

        public void RemoveApartment(Apartment apartment)
        {
            Apartments.Remove(apartment);
        }

        public void AddCommunArea(CommunArea communArea)
        {
            CommunAreas.Add(communArea);
        }

        public void RemoveCommunArea(CommunArea communArea)
        {
            CommunAreas.Remove(communArea);
        }
    }
}
