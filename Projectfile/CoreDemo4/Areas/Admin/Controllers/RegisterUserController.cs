using CoreDemo4.Areas.Admin.Models;
using CoreDemo4.Models;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CoreDemo4.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        public RegisterUserController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        #region Create SuperAdmin
        public async Task<IActionResult> CreateAdmin()
        {
            AppUser appUser = new()
            {
                Name = "Dunya",
                Surname = "Yusifova",
                UserName = "Dunya",
                Email = "Dunya@gmail.com"
            };
            AppRole appRole = new()
            {
                Name = "SuperAdmin"
            };
            AppUser user = await _userManager.FindByEmailAsync(appUser.Email);
            if (!(await _roleManager.RoleExistsAsync("SuperAdmin")))
            {
                await _roleManager.CreateAsync(appRole);
            }
            if (user == null)
            {
                await _userManager.CreateAsync(appUser, "Dunya135.");
                await _userManager.AddToRoleAsync(appUser, appRole.Name);
            }
            else
            {
                return NotFound();
            }
            return RedirectToAction("Index", "Widget");
        }
        #endregion

        #region CreateUser

        public async Task<IActionResult> Index()
        {
            List<AppRole> role = await _roleManager.Roles.Where(x => x.Name != "SuperAdmin").ToListAsync();
            ViewBag.Roles = role;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSingUpViewModel p, string sellectedrole)
        {
            if (ModelState.IsValid)
            {
                List<AppRole> role = await _roleManager.Roles.Where(x => x.Name != "SuperAdmin").ToListAsync();
                ViewBag.Roles = role;
                AppUser user = new AppUser()
                {
                    Email = p.Mail,
                    UserName = p.UserName,
                    Name = p.Name,
                    Surname = p.Surname
                };
                var result = await _userManager.CreateAsync(user, p.Password);
                await _userManager.AddToRoleAsync(user, sellectedrole);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Widget");
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

        #region GetControllerName

        public IActionResult GetControllers()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            var controllerlist = asm.GetTypes()
                    .Where(type => typeof(Controller).IsAssignableFrom(type))
                    .SelectMany(type => type.GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public))
                    .Select(x => new
                    {
                        Controller = x.DeclaringType.Name,
                    })
                     .ToList();
            ViewBag.ControllerList = controllerlist;
            return View(controllerlist);
        }
        #endregion

        #region DeletRole

        public async Task<IActionResult> DeleteRole(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x=>x.Id==2);
            var result = await _roleManager.DeleteAsync(value);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Account");
            }
            return View();
        }

        #endregion

        #region RoleList

        public IActionResult GetRoleList()
        {
            var value = _roleManager.Roles.ToList();

            return View(value);
        }

        #endregion

        #region CreateRoleAsync
        //public async Task CreateRole()

        //{
        //    AppRole appRole = new()
        //    {
        //        Name = "User"
        //    }; 

        //    if (!(await _roleManager.RoleExistsAsync("User")))
        //    {
        //        await _roleManager.CreateAsync(appRole);
        //    }
        //}
        public async Task CreateRole()
        {
            if (!(await _roleManager.RoleExistsAsync(Helpers.Helper.Roles.SuperAdmin.ToString())))
            {
                await _roleManager.CreateAsync(new AppRole { Name = Helpers.Helper.Roles.SuperAdmin.ToString() });
            }
            if (!(await _roleManager.RoleExistsAsync(Helpers.Helper.Roles.Admin.ToString())))
            {
                await _roleManager.CreateAsync(new AppRole { Name = Helpers.Helper.Roles.Admin.ToString() });
            }
            if (!(await _roleManager.RoleExistsAsync(Helpers.Helper.Roles.User.ToString())))
            {
                await _roleManager.CreateAsync(new AppRole { Name = Helpers.Helper.Roles.User.ToString() });
            }
        }
        #endregion

        #region CreateRole

        //public async Task<IActionResult> CreateRole(AppRole role)
        //{
        //    AppRole appRole = new()
        //    {
        //        Name = role.Name
        //    };
        //    //if (!(await _roleManager.RoleExistsAsync(role.Name))) 
        //    //{

        //    var result = await _roleManager.CreateAsync(appRole);
        //    if (result.Succeeded)
        //    {
        //        return RedirectToAction("Index", "Widget");
        //    }
        //    foreach (var item in result.Errors)
        //    {
        //        ModelState.AddModelError("", item.Description);
        //    }
        //    //}
        //    return View(appRole);
        //}

        #endregion
    }
}
