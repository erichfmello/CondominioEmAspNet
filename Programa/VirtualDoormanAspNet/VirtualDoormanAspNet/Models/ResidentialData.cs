using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace VirtualDoormanAspNet.Models
{
    public class ResidentialData
    {
        [Key]
        public string Cnpj { get; set; }
        public string Name { get; set; }
        public int ApartmentLastFloor { get; set; }
        public int Floor { get; set; }
        public int ApartmentPerFloor { get; set; }
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
