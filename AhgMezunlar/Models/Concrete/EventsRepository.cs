using AhgMezunlar.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models.Concrete
{
    public class EventsRepository : IEventsRepository
    {
        private ApplicationDbContext dbContext;
        public EventsRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }


        public void AddEvent(Events events)
        {
            dbContext.Events.Add(events);
            dbContext.SaveChanges();
        }

        public void DeleteEvent(int eventId)
        {
            var events = dbContext.Events.FirstOrDefault(p => p.Id == eventId);
            if (events!=null)
            {
                dbContext.Events.Remove(events);
                dbContext.SaveChanges();
            }
        }

        public IQueryable<Events> GetEvents()
        {
            return dbContext.Events;
        }

        public void SaveEvent(Events events)
        {
            if (events.Id==0)
            {
                AddEvent(events);
            }
            else
            {
                UpdateEvent(events);
            }
        }

        public void UpdateEvent(Events events)
        {
            var updateevent = dbContext.Events.FirstOrDefault(p => p.Id == events.Id);
            if (updateevent!=null)
            {
                updateevent.IconName = events.IconName;
                updateevent.Content = events.Content;
                updateevent.PhotoPath = events.PhotoPath;
                updateevent.PopupState = events.PopupState;
                updateevent.ShowOnPage = events.ShowOnPage;
                updateevent.Title = events.Title;
                dbContext.SaveChanges();
            }
        }
    }
}
