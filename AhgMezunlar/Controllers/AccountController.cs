using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AhgMezunlar.Models;
using AhgMezunlar.Models.Concrete;
using AhgMezunlar.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AhgMezunlar.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        //AccountRepository accountRepository;

        private UserManager<ApplicationUser> userManager;
        private RoleManager<IdentityRole> roleManager;
        private IPasswordValidator<ApplicationUser> passwordValidator;
        private IPasswordHasher<ApplicationUser> passwordHasher;
        private SignInManager<ApplicationUser> signInManager;


        public AccountController(UserManager<ApplicationUser> _userManager,
                               IPasswordValidator<ApplicationUser> _passwordValidator,
                                IPasswordHasher<ApplicationUser> _passwordHasher,
                                RoleManager<IdentityRole> _roleManager,
                                SignInManager<ApplicationUser> _signInManager
                                )
        {
            userManager = _userManager;
            passwordHasher = _passwordHasher;
            passwordValidator = _passwordValidator;
            roleManager = _roleManager;
            signInManager = _signInManager;
        } 


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()

        {
            var login = new LoginViewModel();
            return View(login);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(loginViewModel.Email);
                if (user!=null)
                {
                    await signInManager.SignOutAsync();
                    var result = await signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);


                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                }
                ModelState.AddModelError("Email", "Geçersiz Kullanıcı adı veya Parola");
            }
            return View(loginViewModel);

        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        public async Task<JsonResult> GetAllUsers()
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

            return Json(userInfoModels);

        }

        public async Task<JsonResult> SaveUser(RegisterModel registerModel)
        {
            try
            {
                if (registerModel != null)
                {

                    if (registerModel.UserId == null)
                    {
                        var user = new ApplicationUser();
                        user.Email = registerModel.Email;
                        user.UserName = registerModel.Email;
                        var result = await userManager.CreateAsync(user, registerModel.Password);
                        if (result.Succeeded)
                        {
                            await userManager.AddToRoleAsync(user, registerModel.Role);
                            return Json(1);
                        }
                        else
                        {
                            
                            //result.errors don
                            //validation ekle
                            return Json(result.Errors);
                        }



                    }
                    else
                    {

                        var user = await userManager.FindByIdAsync(registerModel.UserId);
                        if (user != null)
                        {
                            user.Email = registerModel.Email;
                            user.UserName = registerModel.Email;
                            //password not null ise
                            if (registerModel.Password != null)
                            {
                                IdentityResult validPass = await passwordValidator.ValidateAsync(userManager, user, registerModel.Password);
                                if (validPass.Succeeded)
                                {
                                    user.PasswordHash = passwordHasher.HashPassword(user, registerModel.Password);
                                    if (registerModel.Role == "Admin")
                                    {
                                        //admin rol ekle            admin role sahip
                                        //user role çıkar           rol değiştirme
                                        var isAdmin = await userManager.IsInRoleAsync(user, "Admin");

                                        if (!isAdmin)
                                        {

                                            await userManager.AddToRoleAsync(user, registerModel.Role);
                                            await userManager.RemoveFromRoleAsync(user, "User");
                                        }

                                    }
                                    else
                                    {
                                        //user role
                                        //admin role ekle
                                        var isUser = await userManager.IsInRoleAsync(user, "User");
                                        if (!isUser)
                                        {
                                            await userManager.AddToRoleAsync(user, registerModel.Role);
                                            await userManager.RemoveFromRoleAsync(user, "Admin");
                                        }

                                    }

                                    return Json(1);
                                }
                                else
                                {
                                    return Json(-1);
                                }
                            }
                            else //null ise
                            {
                                if (registerModel.Role == "Admin")
                                {
                                    //admin rol ekle            admin role sahip
                                    //user role çıkar           rol değiştirme
                                    var isAdmin = await userManager.IsInRoleAsync(user, "Admin");

                                    if (!isAdmin)
                                    {

                                        await userManager.AddToRoleAsync(user, registerModel.Role);
                                        await userManager.RemoveFromRoleAsync(user, "User");
                                    }

                                }
                                else
                                {
                                    //user role
                                    //admin role ekle
                                    var isUser = await userManager.IsInRoleAsync(user, "User");
                                    if (!isUser)
                                    {
                                        await userManager.AddToRoleAsync(user, registerModel.Role);
                                        await userManager.RemoveFromRoleAsync(user, "Admin");
                                    }

                                }

                                return Json(1);

                            }

                        }
                        else
                        {
                            return Json(-1);
                        }


                    }

                }
                else
                {
                    return Json(-1);
                }
            }
            catch (Exception ex)
            {


                return Json(ex.Message);
            }


        }

        public async Task<JsonResult> DeleteUser(string id)
        {
            try
            {
                var user = userManager.Users.SingleOrDefault(usr => usr.Id == id);
                if (user != null)
                {
                    await userManager.DeleteAsync(user);

                    return Json(1);
                }
                else
                {
                    return Json(-1);
                }

            }
            catch (Exception Ex)
            {
                return Json(Ex.Message);
             
            }
        }


    }
}