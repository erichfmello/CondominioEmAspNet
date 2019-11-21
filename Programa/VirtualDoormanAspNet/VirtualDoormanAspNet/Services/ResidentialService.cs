using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualDoormanAspNet.Models;

namespace VirtualDoormanAspNet.Services
{
    public class ResidentialService
    {
        private readonly VirtualDoormanAspNetContext _context;

        public ResidentialService(VirtualDoormanAspNetContext context)
        {
            _context = context;
        }

        public void Insert(ResidentialData residentialData, ResidentialAddress residentialAddress)
        {
            _context.Add(residentialData);

            residentialAddress.ResidentialData = residentialData;
            _context.Add(residentialAddress);

            _context.SaveChanges();
        }
    }
}
