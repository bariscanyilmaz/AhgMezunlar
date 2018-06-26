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
        
        private UserManager<ApplicationUser> userManager;


        public HomeController(UserManager<ApplicationUser> _userManager)
        {
            userManager = _userManager;
        }


        public IActionResult Index()
        {
            return View();
        }


    }
}