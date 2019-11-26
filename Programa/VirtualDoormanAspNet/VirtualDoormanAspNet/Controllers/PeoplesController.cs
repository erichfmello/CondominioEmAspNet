using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VirtualDoormanAspNet.Services;
using VirtualDoormanAspNet.Models.ViewModels;

namespace VirtualDoormanAspNet.Controllers
{
    public class PeoplesController : Controller
    {
        private readonly PeopleService _peopleService;
        private readonly ApartmentService _apartmentService;

        public PeoplesController(PeopleService peopleService, ApartmentService apartmentService)
        {
            _peopleService = peopleService;
            _apartmentService = apartmentService;
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
    }
}