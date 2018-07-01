using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models.Abstract
{
    public interface IEventsRepository
    {
        Events GetEvent(int id);
        IQueryable<Events> GetEvents();
        IQueryable<Events> GetShowOnPage();
        void DeleteEvent(int eventId);
        void AddEvent(Events events);
        void UpdateEvent(Events events);

    }
}
