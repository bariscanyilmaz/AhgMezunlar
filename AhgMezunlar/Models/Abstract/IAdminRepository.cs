using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models.Abstract
{
    public interface IAdminRepository
    {
        IQueryable<ContactForm> GetContacts();
        void DeleteContact(int contactId);
        /// <summary>
        /// okunu durumu değişikliği yapıldığında 
        /// kullanılacak metot
        /// </summary>
        /// <param name="isRead"></param>
        void UpdateContact(bool isRead, int contactId);
        void AddContact(ContactForm contactForm);
        
    }
}
