using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace VirtualDoormanAspNet.Models
{
    public class People
    {
        [Key]
        public string Cpf { get; set; }
        public string Name { get; set; }
        public string Rg { get; set; }
        public string PhoneDdd { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

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
