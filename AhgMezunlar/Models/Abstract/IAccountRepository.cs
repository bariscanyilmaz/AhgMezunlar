using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models.Abstract
{
    interface IAccountRepository
    {
        ApplicationUser GetUser(string email);
        IQueryable<ApplicationUser> GetUsers();
        void AddUser(ApplicationUser user);
        void DeleteUser(string email);
        void UpdateUser(ApplicationUser user);
        void SaveUser(ApplicationUser user);

    }
}
