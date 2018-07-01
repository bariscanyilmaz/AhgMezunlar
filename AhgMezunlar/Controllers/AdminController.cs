using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AhgMezunlar.Models;
using AhgMezunlar.Models.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace AhgMezunlar.Controllers
{
    public class AdminController : Controller
    {
        private IAdminRepository adminRepository;
        private ISliderRepository sliderRepository;
        private IEventsRepository eventsRepository; 

        public AdminController(IAdminRepository _adminRepository,ISliderRepository _sliderRepository, IEventsRepository _eventsRepository)
        {
            adminRepository = _adminRepository;
            sliderRepository = _sliderRepository;
            eventsRepository = _eventsRepository;
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

        [HttpPost]
        public async Task<JsonResult> AddOrUpdateEvents(Events events)
        {
            try
            {
                if (events!=null)
                {
                    var files = HttpContext.Request.Form.Files;
                    //Yeni Event oluşturma
                    if (events.Id==0)
                    {
                        Events newEvent = new Events();
                        newEvent.IconName = events.IconName;
                        newEvent.ShowOnPage = events.ShowOnPage;
                        newEvent.Title = events.Title;
                        newEvent.PopupState = events.PopupState;
                        newEvent.Content = events.Content;

                        //image save
                        if (files!=null)
                        {
                            var file = files[0];

                            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\Events", file.FileName);
                            using (var stream = new FileStream(path, FileMode.Create))
                            {
                                await file.CopyToAsync(stream);
                            }

                            newEvent.PhotoPath = file.FileName;
                            eventsRepository.AddEvent(newEvent);

                        }
                        else
                        {
                            eventsRepository.AddEvent(newEvent);
                        }

                        return Json(1);
                    }
                    return Json(1);
                }
                return Json(0);
                




            }
            catch (Exception e)
            {

                return Json(-1);
            }
            
        }
    }
}