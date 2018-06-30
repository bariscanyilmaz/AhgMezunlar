using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AhgMezunlar.Models;
using AhgMezunlar.Models.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AhgMezunlar.Controllers
{
    public class AdminController : Controller
    {
        private IAdminRepository adminRepository;

        public AdminController(IAdminRepository _adminRepository)
        {
            adminRepository = _adminRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult AddContact(ContactForm contactForm)
        {

            try
            {

                adminRepository.AddContact(contactForm);

                return Json(1);
            }
            catch (Exception e)
            {

                return Json(-1);
            }
        }
    }
}