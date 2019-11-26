using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace VirtualDoormanAspNet.Models
{
    public class People
    {
        [Key]
        [Display(Name = "C.P.F.")]
        public string Cpf { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "R.G.")]
        public string Rg { get; set; }

        [Display(Name = "DDD")]
        public string PhoneDdd { get; set; }

        [Display(Name = "Telefone")]
        public string PhoneNumber { get; set; }

        [Display(Name = "e-mail")]
        public string Email { get; set; }

        public ApartmentPeople ApartmentPeople { get; set; }

        [Display(Name = "Apartamento")]
        public int ApartmentNumber { get; set; }

        public People()
        {
        }

        public People(string cpf, string name, string rg, string phoneDdd, string phoneNumber, string email)
        {
            Cpf = cpf;
            Name = name;
            Rg = rg;
            PhoneDdd = phoneDdd;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
