using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models.Abstract
{
    interface IEventsRepository
    {
        IQueryable<Events> GetEvents();
        void DeleteEvent(int eventId);
        void AddEvent(Events events);
        void Update(Events events);
        void SaveEvent(Events events);




    }
}
