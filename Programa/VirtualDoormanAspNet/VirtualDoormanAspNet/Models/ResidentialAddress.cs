using System.ComponentModel.DataAnnotations;

namespace VirtualDoormanAspNet.Models
{
    public class ResidentialAddress
    {
        public int Id { get; set; }

        [Display(Name = "Endereço Residencial")]
        public string Address { get; set; }

        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Display(Name = "Bairro")]
        public string Neighborhood { get; set; }

        [Display(Name = "U.F.")]
        public string Uf { get; set; }

        [Display(Name = "Número")]
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