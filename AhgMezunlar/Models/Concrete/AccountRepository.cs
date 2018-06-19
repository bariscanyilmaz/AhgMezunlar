using AhgMezunlar.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models.Concrete
{
    public class AccountRepository : IAccountRepository
    {
        public void AddUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(string email)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser GetUser(string email)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ApplicationUser> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void SaveUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
    }
}
