using System.Collections.Generic;

namespace VirtualDoormanAspNet.Models
{
    public class Apartment
    {
        public int ApartmentNumber { get; set; }
        public int Floor { get; set; }
        public int Final { get; set; }
        public string Block { get; set; }

        public ResidentialData ResidentialData { get; set; }

        public Apartment()
        {
        }

        public Apartment(int apartmentNumber, int floor, int final, string block, ResidentialData residentialData)
        {
            ApartmentNumber = apartmentNumber;
            Floor = floor;
            Final = final;
            Block = block;
            ResidentialData = residentialData;
        }
    }
}