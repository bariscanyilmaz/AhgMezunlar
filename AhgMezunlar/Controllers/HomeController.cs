using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AhgMezunlar.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AhgMezunlar.Controllers
{
    public class HomeController : Controller
    {
        private IRepository Repository;
        private UserManager<ApplicationUser> userManager;


        public HomeController(IRepository repository,UserManager<ApplicationUser> _userManager)
        {
            Repository = repository;
            userManager = _userManager;
        }


        public IActionResult Index()
        {
            return View(userManager.Users);
        }


    }
}