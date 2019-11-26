using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VirtualDoormanAspNet.Services;
using VirtualDoormanAspNet.Models.ViewModels;
using VirtualDoormanAspNet.Models;

namespace VirtualDoormanAspNet.Controllers
{
    public class PeoplesController : Controller
    {
        private readonly PeopleService _peopleService;
        private readonly ApartmentService _apartmentService;
        private readonly ApartmentPeopleService _apartmentPeopleService;

        public PeoplesController(PeopleService peopleService, ApartmentService apartmentService, ApartmentPeopleService apartmentPeopleService)
        {
            _peopleService = peopleService;
            _apartmentService = apartmentService;
            _apartmentPeopleService = apartmentPeopleService;
        }

        public IActionResult Index()
        {
            var list = _peopleService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var apartments = _apartmentService.FindAll();
            var viewModel = new ViewModelApartmentPeople { Apartments = apartments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(People people)
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }

            _peopleService.Insert(people);

            ApartmentPeople apartmentPeople = new ApartmentPeople(_apartmentService.FindByApartmentNumber(people.ApartmentNumber), people);
            _apartmentPeopleService.Insert(apartmentPeople);

            Apartment apartment = _apartmentService.FindByApartmentNumber(people.ApartmentNumber);
            apartment.ApartmentPeople = apartmentPeople;
            _apartmentService.Update(apartment);

            return RedirectToAction(nameof(Index));
        }
    }
}