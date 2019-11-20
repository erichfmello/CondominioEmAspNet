namespace VirtualDoormanAspNet.Models
{
    public class ResidentialAddress
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Cep { get; set; }
        public string Neighborhood { get; set; }
        public string Uf { get; set; }
        public string Number { get; set; }

        public ResidentialData ResidentialData { get; set; }

        public ResidentialAddress()
        {
        }

        public ResidentialAddress(int id, string address, string cep, string neighborhood, string uf, string number, ResidentialData residentialData)
        {
            Id = id;
            Address = address;
            Cep = cep;
            Neighborhood = neighborhood;
            Uf = uf;
            Number = number;
            ResidentialData = residentialData;
        }
    }
}