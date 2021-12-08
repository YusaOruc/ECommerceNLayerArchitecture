using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.UserPanel;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concreate.EntityFramework;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ECommerce.Controllers
{
    [Authorize]
    public class AdminUserController : Controller
    {
        UserManager userManager = new UserManager(new UserDal());
        AdminManager adminManager = new AdminManager(new AdminDal());
        [HttpGet]
        public IActionResult Index(string p,int page = 1)
        {
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            if (validation == "Admin")
            {
                if (string.IsNullOrEmpty(p))
                {
                    var values = userManager.GetListAllService().ToPagedList(page, 5);
                    return View(values);
                }
                else
                {
                    var values = userManager.GetListAllService(x => x.UserName.Contains(p)).ToPagedList(page, 5);
                    return View(values);
                }
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            
            
            
        }
        
        [HttpGet]
        public IActionResult UpdateUsers(int id)
        {
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            if (validation == "Admin")
            {
                var values = userManager.GetByIDService(id);
                return View(values);

            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            
        }
        [HttpPost]
        public IActionResult UpdateUsers(User user)
        {
            RegisterValidator validationRules = new RegisterValidator();
            ValidationResult result = validationRules.Validate(user);
            if (result.IsValid)
            {
                userManager.UpdateService(user);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteUser(int id)
        {
            var values = userManager.GetByIDService(id);
            userManager.DeleteService(values);
            return RedirectToAction("Index");
        }

    }
}