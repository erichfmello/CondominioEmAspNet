using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualDoormanAspNet.Models;

namespace VirtualDoormanAspNet.Services
{
    public class PeopleService
    {
        private readonly VirtualDoormanAspNetContext _context;

        public PeopleService(VirtualDoormanAspNetContext context)
        {
            _context = context;
        }

        public List<People> FindAll()
        {
            return _context.People.ToList();
        }

        public void Insert(People people)
        {
            _context.Add(people);
            _context.SaveChanges();
        }
    }
}
