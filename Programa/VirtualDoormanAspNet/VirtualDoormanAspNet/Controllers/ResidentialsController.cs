using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VirtualDoormanAspNet.Services;
using VirtualDoormanAspNet.Models;

namespace VirtualDoormanAspNet.Controllers
{
    public class ResidentialsController : Controller
    {
        private readonly ResidentialService _residentialService;
        private readonly ApartmentService _apartmentService;

        public ResidentialsController(ResidentialService residentialService, ApartmentService apartmentService)
        {
            _residentialService = residentialService;
            _apartmentService = apartmentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ResidentialData residentialData, ResidentialAddress residentialAddress)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            _residentialService.Insert(residentialData, residentialAddress);

            for (int i = 0; i < residentialData.NumberBlock; i++)
            {
                for (int j = 0; j < residentialData.Floor; j++)
                {
                    for (int k = 0; k < residentialData.ApartmentPerFloor; k++)
                    {
                        if (residentialData.NumberBlock <= 1)
                        {
                            int apartmentNumber = (j + 1) * 10 + k + 1;
                            int floor = (j + 1);
                            int final = k + 1;
                            string block = (i + 1).ToString();

                            Apartment apartment = new Apartment(apartmentNumber, floor, final, block, residentialData);
                            _apartmentService.Insert(apartment);
                        } else
                        {
                            int apartmentNumber = Convert.ToInt32((i + 1).ToString() + ((j + 1) * 10 + k + 1).ToString());
                            int floor = (j + 1);
                            int final = k + 1;
                            string block = (i + 1).ToString();

                            Apartment apartment = new Apartment(apartmentNumber, floor, final, block, residentialData);
                            _apartmentService.Insert(apartment);
                        }
                    }
                }
            }

            return RedirectToAction("Index", "Home");
        }
    }
}