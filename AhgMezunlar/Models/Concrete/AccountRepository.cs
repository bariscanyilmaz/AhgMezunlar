using AhgMezunlar.Models.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models.Concrete
{
    public class AccountRepository : IAccountRepository
    {
        private UserManager<ApplicationUser> userManager;
        private RoleManager<IdentityRole> roleManager;
        private IPasswordValidator<ApplicationUser> passwordValidator;
        private IPasswordHasher<ApplicationUser> passwordHasher;


        public AccountRepository(UserManager<ApplicationUser> _userManager,
                                RoleManager<IdentityRole> _roleManager,
                                IPasswordValidator<ApplicationUser> _passwordValidator,
                                IPasswordHasher<ApplicationUser> _passwordHasher)
        {
            userManager = _userManager;
            roleManager = _roleManager;
            passwordHasher = _passwordHasher;
            passwordValidator = _passwordValidator;
        }


        public void AddUser(RegisterModel registerModel)
        {

        }

        public void DeleteUser(string email)
        {
            
        }

        public ApplicationUser GetUser(string email)
        {
            return userManager.Users.SingleOrDefault();
        }

        public async Task<List<UserInfoModel>> GetUsers()
        {
            List<UserInfoModel> userInfoModels = new List<UserInfoModel>();

            var users = userManager.Users;

            foreach (var item in users)
            {
                var userInfo = new UserInfoModel();
                userInfo.Id = item.Id;
                userInfo.Email = item.Email;
                var rols = await userManager.GetRolesAsync(item);
                userInfo.Role = rols.SingleOrDefault();
                userInfoModels.Add(userInfo); 
            }

            return userInfoModels;
        }

        public void SaveUser(RegisterModel registerModel)
        {
            
        }
        
        public void UpdateUser(RegisterModel registerModel)
        {
            
        }

    }
}
