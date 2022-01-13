using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.UserPanel;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concreate.EntityFramework;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        UserManager userManager = new UserManager(new UserDal());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {
            var value=userManager.LoginUserService(user);
            
            

            if (value != null)
            {

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.UserMail)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "HomeProduct");
            }
            else
            {
             
                return View();
            }
            
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            RegisterValidator validationRules = new RegisterValidator();
            ValidationResult result = validationRules.Validate(user);
            if (result.IsValid)
            {
                userManager.InsertService(user);
                System.Threading.Thread.Sleep(2000);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            
            return RedirectToAction("Index", "Login");
        }
    }
}
