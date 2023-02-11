using CoreDemo4.Areas.Admin.Models;
using CoreDemo4.EmailServices;
using CoreDemo4.Models;
using DataAccessLayer.Concrete;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo4.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private  IEmailSender  _iemailSender;
        public AccountController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IEmailSender iemailSender)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
            _iemailSender = iemailSender;
        }

        public IActionResult TempDataId()
        {
            TempData["UserId"] = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View();

        }

        #region CreateUser

        public async Task<IActionResult> Index()
        {
            var value = Helpers.Helper.Roles.User.ToString();
            ViewBag.v = value;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSingUpViewModel p)
        {

            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Email = p.Mail,
                    UserName = p.UserName,
                    Name = p.Name,
                    Surname = p.Surname

                };
                var result = await _userManager.CreateAsync(user, p.Password);
                await _userManager.AddToRoleAsync(user, Helpers.Helper.Roles.User.ToString());

                if (result.Succeeded)
                { 
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var url = Url.Action("ConfirmEmail", "Account", new
                    {
                        userId = user.Id,
                        token = code
                    });
                    //email
                    await _iemailSender.SendEmailAsync(p.Mail, "Hesabınızı onaylayin.", $"Lütfen email hesabınızı onaylamak için linke <a href='https://localhost:44323{url}'>daxil olun.</a>");
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }
            return View(p);
        }

        #endregion

        #region Login

        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser appUser = await _userManager.FindByEmailAsync(login.Email);
            if (appUser == null)
            {
                ModelState.AddModelError("", "Belə hesab mövcud deyil.");
                return View();
            }

            if (!await _userManager.IsEmailConfirmedAsync(appUser))
            {
                ModelState.AddModelError("","Lütfen email hesabınıza gelen link ile üyüliğinizi onaylayın.");
                return View(login);
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(appUser, login.Password, true, true);
            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "Siz bir dəqiqəlik bloklanmısınız.");
                return View();
            }
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Sizin şifrəniz yanlışdır");
                return View();
            }
            return RedirectToAction("Index", "Dashboard");
        }
        #endregion

        #region LogOut

        public IActionResult LogOut()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("LogIn", "Account");
        }

        #endregion

        #region UserList
        public async Task<IActionResult> UserList()
        {
            List<AppUser> users = await _userManager.Users.ToListAsync();
            List<UserVM> userVMs = new List<UserVM>();
            List<AppRole> role = await _roleManager.Roles.ToListAsync();
            TempData["UserId"] = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.Roles = role;
            foreach (AppUser user in users)
            {
                UserVM userVM = new UserVM()
                {
                    Id = user.Id,
                    Name = user.Name,
                    Surname = user.Surname,
                    Username = user.UserName,
                    Email = user.Email,
                    Role = (await _userManager.GetRolesAsync(user)).FirstOrDefault()
                };
                userVMs.Add(userVM);
            }
            return View(userVMs);
        }
        #endregion

        #region UpdateUser

        [HttpGet]
        public async Task<IActionResult> UpdateUser(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return BadRequest();
            }
            UpdateUserVM updateUser = new UpdateUserVM()
            {
                Name = user.Name,
                Surname = user.Surname,
                UserName = user.UserName,
                Mail = user.Email,
                About = user.About
            };
            return View(updateUser);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateUser(string id, UpdateUserVM userVM)
        {
            if (id == null)
            {
                return NotFound();
            }
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return BadRequest();
            }
            UpdateUserVM updateUserdb = new UpdateUserVM()
            {
                Name = user.Name,
                Surname = user.Surname,
                UserName = user.UserName,
                Mail = user.Email,
                About = user.About
            };
            if (!ModelState.IsValid)
            {
                return View(updateUserdb);
            }
            user.Email = userVM.Mail;
            user.UserName = userVM.UserName;
            user.Name = userVM.Name;
            user.Surname = userVM.Surname;
            user.About = userVM.About;
            await _userManager.UpdateAsync(user);
            return RedirectToAction("Index");
        }
        #endregion

        #region ResetPassword
        //[HttpGet]
        //public IActionResult Request()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<ActionResult> Request(ResetPasswordModel model)
        //{
        //    var value = await _userManager.FindByNameAsync(User.Identity.Name);
        //    value.PasswordHash = _userManager.PasswordHasher.HashPassword(value, model.Passwords);


        //    if (model.Passwords != model.ConfirmPassword)
        //    {
        //        ModelState.AddModelError("", "Şifreler aynı deyil");
        //    }
        //    else
        //    {
        //        await _userManager.UpdateAsync(value);
        //    }

        //    return RedirectToAction("Index", "Dashboard");

        //}

        #endregion

        #region ConfirmEmail

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if ( userId==null || token == null)
            {
                var mesage = "Gecersiz token";
                ViewBag.mesage1 = mesage;
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    var mesage2 = "Hesabiniz onaylandi";
                    ViewBag.mesage2 = mesage2;
                    //TempData["message"] = "Hesabiniz onaylandi";
                    return View();
                }
              
            }
            var mesage3 = "Hesabiniz onaylanmadi";
            ViewBag.mesage3 = mesage3;
            //TempData["message"] = "Hesabınız onaylanmadı.";
            return View();
        }

        #endregion

        #region ForgotPassword
        public IActionResult ForgotPassword()
        {
           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if (string.IsNullOrEmpty(Email))
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(Email);

            if (user == null)
            {
                return View();
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);

            var url = Url.Action("ResetPassword", "Account", new
            {
                userId = user.Id,
                token = code
            });

            // email
            await _iemailSender.SendEmailAsync(Email, "Reset Password", $"Parolanızı yenilemek için linke <a https://localhost:44323{url}'>tıklayın</a>");


            return View();
        }
        #endregion

        #region ResetPassword
        [HttpGet]
        public IActionResult ResetPassword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return RedirectToAction("Index", " Dashboard");
            }


            var model = new ResetPasswordModel { Token = token };

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return RedirectToAction("Index", " Dashboard");
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Passwords);

            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }

            return View(model);
        }


        public IActionResult AccessDenied()
        {
            return View();
        }
        #endregion
    }
}
