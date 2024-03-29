﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualDoormanAspNet.Models;

namespace VirtualDoormanAspNet.Services
{
    public class ApartmentService
    {
        private readonly VirtualDoormanAspNetContext _context;

        public ApartmentService(VirtualDoormanAspNetContext context)
        {
            _context = context;
        }

        public void Insert(Apartment apartment)
        {
            _context.Add(apartment);
            _context.SaveChanges();
        }

        public List<Apartment> FindAll()
        {
            return _context.Apartment.OrderBy(x => x.ApartmentNumber).ToList();
        }

        public Apartment FindByApartmentNumber(int apartmentNumber)
        {
            return _context.Apartment.FirstOrDefault(obj => obj.ApartmentNumber == apartmentNumber);
        }

        public void Update(Apartment apartment)
        {
            _context.Update(apartment);
            _context.SaveChanges();
        }
    }
}
