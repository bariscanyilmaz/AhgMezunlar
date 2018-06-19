using AhgMezunlar.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models.Concrete
{
    public class AdminRepository : IAdminRepository
    {
        private ApplicationDbContext dbContext;
        public AdminRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }


        public void DeleteContact(int contactId)
        {
            var contact = dbContext.Contacts.FirstOrDefault(c => c.Id == contactId);
            if (contact!=null)
            {
                dbContext.Contacts.Remove(contact);
                dbContext.SaveChanges();
            }

        }

        public IQueryable<ContactForm> GetContacts()
        {
            return dbContext.Contacts;
        }

        public void UpdateContact(bool readit,int contactId)
        {
            var contact = dbContext.Contacts.FirstOrDefault(c => c.Id == contactId);
            if (contact!=null)
            {
                contact.ReadIt = readit;
                dbContext.SaveChanges();
            }
        }
    }
}
