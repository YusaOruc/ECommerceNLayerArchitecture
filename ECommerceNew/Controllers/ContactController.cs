using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.UserPanel;
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
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new ContactDal());
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            ContactValidator validationRules = new ContactValidator();
            ValidationResult result = validationRules.Validate(contact);
            if (result.IsValid)
            {
                contactManager.InsertService(contact);
                return RedirectToAction("Index","HomeProduct");
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
