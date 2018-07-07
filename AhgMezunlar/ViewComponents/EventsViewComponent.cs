using AhgMezunlar.Models.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.ViewComponents
{
    public class EventsViewComponent:ViewComponent
    {
        private IEventsRepository eventsRepository;

        public EventsViewComponent(IEventsRepository _eventsRepository) => eventsRepository = _eventsRepository;

        public IViewComponentResult Invoke()
        {
            return View(eventsRepository.GetShowOnPage().Take(3).ToList());
        }
    }
}
