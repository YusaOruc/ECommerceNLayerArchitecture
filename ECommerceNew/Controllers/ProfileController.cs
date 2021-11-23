using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.UserPanel;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concreate.EntityFramework;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    public class ProfileController : Controller
    {
        UserManager userManager = new UserManager(new UserDal());
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            var userID = userManager.GetListAllService(x => x.UserMail == usermail).Select(y => y.UserID).FirstOrDefault();
            var values = userManager.GetListAllService(x=>x.UserID==userID);
            return View(values);
        }
        [HttpGet]
        public IActionResult ProfileGetDetails(int id)
        {
            var values = userManager.GetByIDService(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult ProfileGetDetails(User user)
        {
            RegisterValidator validationRules = new RegisterValidator();
            ValidationResult result = validationRules.Validate(user);
            if(result.IsValid)
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
    }
}
