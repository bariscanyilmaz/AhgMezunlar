using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AhgMezunlar.Models;
using AhgMezunlar.Models.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AhgMezunlar.Controllers
{
    public class HomeController : Controller
    {

        private ISliderRepository sliderRepository;


        public HomeController(ISliderRepository _sliderRepository)
        {
            sliderRepository = _sliderRepository;
        }


        public IActionResult Index()
        {
            return View(sliderRepository.GetSliderImages());
        }


    }
}