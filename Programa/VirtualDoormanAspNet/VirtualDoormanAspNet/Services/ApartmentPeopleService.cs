using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualDoormanAspNet.Models;

namespace VirtualDoormanAspNet.Services
{
    public class ApartmentPeopleService
    {
        public readonly VirtualDoormanAspNetContext _context;

        public ApartmentPeopleService(VirtualDoormanAspNetContext context)
        {
            _context = context;
        }

        public void Insert(ApartmentPeople apartmentPeople)
        {
            _context.Add(apartmentPeople);
            _context.SaveChanges();
        }
    }
}
