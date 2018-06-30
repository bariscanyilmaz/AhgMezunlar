using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AhgMezunlar.Models;
using AhgMezunlar.Models.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AhgMezunlar.Controllers
{
    public class AdminController : Controller
    {
        private IAdminRepository adminRepository;
        private ISliderRepository sliderRepository;

        public AdminController(IAdminRepository _adminRepository,ISliderRepository _sliderRepository)
        {
            adminRepository = _adminRepository;
            sliderRepository = _sliderRepository;

        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> AddSliderImage()
        {
            try
            {
                var files = HttpContext.Request.Form.Files;

                foreach (var item in files)
                {
                    if (item != null)
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\Slider", item.FileName);

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await item.CopyToAsync(stream);
                            SliderImage sliderImage = new SliderImage();
                            sliderImage.Path = item.FileName;
                            sliderRepository.AddSliderIamge(sliderImage);
                        }
                    }
                }

                return Json(1);    
            }
            catch (Exception e)
            {

                return Json(-1);
            }

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

        public JsonResult AddOrUpdateEvents(Events events, IFormFile image)
        {
            try
            {
                var files = HttpContext.Request.Form.Files;

                return Json(1);
            }
            catch (Exception e)
            {
                return Json(-1);

            }
            
        }
    }
}