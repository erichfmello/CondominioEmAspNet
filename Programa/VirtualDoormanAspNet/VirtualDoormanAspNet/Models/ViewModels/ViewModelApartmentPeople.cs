using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualDoormanAspNet.Models.ViewModels
{
    public class ViewModelApartmentPeople
    {
        public People People { get; set; }
        public ICollection<Apartment> Apartments { get; set; }
    }
}
