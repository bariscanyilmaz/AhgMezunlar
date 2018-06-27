using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models.Abstract
{
    public interface IAccountRepository
    {
        ApplicationUser GetUser(string email);
        IQueryable<ApplicationUser> GetUsers();
        void AddUser(RegisterModel registerModel);
        void DeleteUser(string email);
        void UpdateUser(RegisterModel registerModel);
        void SaveUser(RegisterModel registerModel);

    }
}
