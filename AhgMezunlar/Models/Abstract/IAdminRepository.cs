using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models.Abstract
{
    interface IAdminRepository
    {
        IQueryable<ContactForm> GetContacts();
        void DeleteContact(int contactId);
        /// <summary>
        /// okunu durumu değişikliği yapıldığında 
        /// kullanılacak metot
        /// </summary>
        /// <param name="readit"></param>
        void UpdateContact(bool readit);
        
    }
}
