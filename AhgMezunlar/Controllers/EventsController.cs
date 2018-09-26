using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AhgMezunlar.Models.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AhgMezunlar.Controllers
{
    public class EventsController : Controller
    {
        private IEventsRepository eventsRepository;

        public EventsController(IEventsRepository _eventsRepository)
        {
            eventsRepository = _eventsRepository;
        }

        public IActionResult Index()
        {
            return View(eventsRepository.GetEvents().ToList());
        }
    }
}