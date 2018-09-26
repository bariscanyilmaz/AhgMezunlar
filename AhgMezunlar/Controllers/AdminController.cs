using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AhgMezunlar.Models;
using AhgMezunlar.Models.Abstract;
using AhgMezunlar.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace AhgMezunlar.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IAdminRepository adminRepository;
        private ISliderRepository sliderRepository;
        private IEventsRepository eventsRepository;
        private IMomentsRepository momentsRepository;
        public AdminController(IAdminRepository _adminRepository, ISliderRepository _sliderRepository, IEventsRepository _eventsRepository, IMomentsRepository _momentsRepository)
        {
            adminRepository = _adminRepository;
            sliderRepository = _sliderRepository;
            eventsRepository = _eventsRepository;
            momentsRepository = _momentsRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }

        #region Slider Functions
        [HttpGet]
        public JsonResult GetSliderImages()
        {
            return Json(sliderRepository.GetSliderImages());
        }
        [HttpPost]
        public async Task<JsonResult> AddSliderImage()
        {
            try
            {
                var files = HttpContext.Request.Form.Files;
                if (files != null)
                {


                    foreach (var item in files)
                    {
                        if (item != null)
                        {
                            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\Slider", item.FileName);

                            using (var stream = new FileStream(path, FileMode.Create))
                            {
                                await item.CopyToAsync(stream);
                            }

                            SliderImage sliderImage = new SliderImage();
                            sliderImage.Path = item.FileName;
                            sliderRepository.AddSliderIamge(sliderImage);
                        }
                    }

                    return Json(1);
                }
                else
                {
                    return Json(-1);
                }
            }
            catch (Exception e)
            {

                return Json(-1);
            }

        }
        [HttpPost]
        public JsonResult DeleteSliderImage(int id)
        {
            var sliderIamge = sliderRepository.GetSliderImage(id);

            if (sliderIamge != null)
            {
                sliderRepository.DeleteSliderImage(id);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\Slider", sliderIamge.Path);
                System.IO.File.Delete(path);

                return Json(1);
            }
            else
            {
                return Json(-1);
            }
        }
        [HttpPost]
        [AllowAnonymous]
        public JsonResult AddContact(ContactForm contactForm)
        {

            try
            {

                if (contactForm.ContactEmail != null || contactForm.Content!=null || contactForm.Object!=null || contactForm.SenderName!=null)
                {
                    adminRepository.AddContact(contactForm);
                    return Json(1);
                }
                else
                {
                    return Json(-1);

                }
            }
            catch (Exception e)
            {
                return Json(-1);
            }
        }
        #endregion

        #region Event Functions
        [HttpPost]
        public async Task<JsonResult> AddOrUpdateEvents(Events events)
        {
            var files = HttpContext.Request.Form.Files;
            IFormFile file;

            try
            {
                if (events != null)
                {
                    
                    //Yeni Event oluşturma
                    if (events.Id == 0)
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
                            file = files[0];

                            if (file != null)
                            {


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

                        }

                    }
                    else
                    {
                        var oldEvent = eventsRepository.GetEvent(events.Id);
                        oldEvent.IconName = events.IconName;
                        oldEvent.PopupState = events.PopupState;
                        oldEvent.ShowOnPage = events.ShowOnPage;
                        oldEvent.Title = events.Title;
                        oldEvent.Content = events.Content;

                        if (files.Count>0)
                        {
                            file = files[0];
                            if (file!=null)
                            {
                                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\Events", file.FileName);
                                using (var stream = new FileStream(path, FileMode.Create))
                                {
                                    await file.CopyToAsync(stream);
                                }

                                var oldEventPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\Events", oldEvent.PhotoPath);
                                System.IO.File.Delete(oldEventPath);
                                oldEvent.PhotoPath = file.FileName;
                                eventsRepository.UpdateEvent(oldEvent);

                            }
                            else
                            {
                                eventsRepository.UpdateEvent(oldEvent);
                            }
                        }
                        else
                        {
                            eventsRepository.UpdateEvent(oldEvent);
                        }

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
        [HttpPost]
        public JsonResult DeleteEvent(int id)
        {
            var deleteEvent = eventsRepository.GetEvent(id);
            if (deleteEvent != null)
            {
                eventsRepository.DeleteEvent(id);

                var oldEventPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\Events", deleteEvent.PhotoPath);
                System.IO.File.Delete(oldEventPath);

                return Json(1);
            }
            else
            {
                return Json(-1);
            }
        }
        [HttpPost]
        public JsonResult UpdatePopUp(int id, bool state)
        {
            var allEvents = eventsRepository.GetEvents();
            foreach (var item in allEvents)
            {
                item.PopupState = false;
                eventsRepository.UpdateEvent(item);
            }

            var ev = eventsRepository.GetEvent(id);
            if (ev != null)
            {

                ev.PopupState = state;
                eventsRepository.UpdateEvent(ev);
                return Json(1);
            }
            else
            {
                return Json(-1);
            }

        }
        [HttpGet]
        public JsonResult GetShowingEvents()
        {
            return Json(eventsRepository.GetEvents().Where(ev => ev.ShowOnPage == true).ToList());
        }

        public JsonResult GetOldEvents()
        {
            return Json(eventsRepository.GetEvents().Where(ev => ev.ShowOnPage == false).ToList());
        }

        public JsonResult UpdateEventShowOnPageState(int id, bool showOnPage)
        {
            var ev = eventsRepository.GetEvent(id);
            if (ev != null)
            {
                ev.ShowOnPage = showOnPage;
                if (showOnPage==false)
                {
                    ev.PopupState = false;
                }

                eventsRepository.UpdateEvent(ev);

                return Json(1);
            }
            else
            {
                return Json(-1);
            }

        }

        #endregion

        #region Moments Functions
        [HttpGet]
        public JsonResult GetMoments()
        {
            return Json(momentsRepository.GetMoments().ToList());
        }
        [HttpPost]
        public JsonResult DeleteMoment(int id)
        {
            var moment = momentsRepository.GetMoments().SingleOrDefault(i => i.Id == id);

            if (moment != null)
            {
                momentsRepository.DeleteMoment(id);

                return Json(1);
            }
            else
            {
                return Json(-1);
            }
        }
        [HttpPost]
        public JsonResult UpdateMoment(int id, bool showState)
        {
            var moment = momentsRepository.GetMoment(id);
            if (moment != null)
            {
                momentsRepository.UpdateMoment(showState, id);
                return Json(1);
            }
            else
            {
                return Json(-1);
            }
        }

        #endregion

        #region Contact Message Methodss

        [HttpGet]
        public JsonResult GetAllContactMessages()
        {
            return Json(adminRepository.GetContacts().ToList());
        }
        [HttpGet]
        public JsonResult GetUnreadMessages()
        {
            return Json(adminRepository.GetContacts().Where(c => c.IsRead == false).ToList());
        }
        [HttpGet]
        public JsonResult GetReadMessages()
        {
            return Json(adminRepository.GetContacts().Where(c => c.IsRead == true).ToList());
        }

        [HttpPost]
        public JsonResult UpdateMessage(int id, bool isread)
        {
            var message = adminRepository.GetContacts().FirstOrDefault(c => c.Id == id);
            if (message != null)
            {
                adminRepository.UpdateContact(isread, id);
                return Json(1);
            }
            else
            {
                return Json(-1);
            }
        }
        [HttpPost]
        public JsonResult DeleteMessage(int id)
        {
            var contact = adminRepository.GetContacts().SingleOrDefault(c => c.Id == id);
            if (contact != null)
            {
                adminRepository.DeleteContact(id);
                return Json(1);
            }
            else
            {
                return Json(-1);
            }
        }

        #endregion



    }
}