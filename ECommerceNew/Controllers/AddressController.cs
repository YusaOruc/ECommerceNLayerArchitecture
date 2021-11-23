using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.UserPanel;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concreate.EntityFramework;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    public class AddressController : Controller
    {
        AddressManager addressManager = new AddressManager(new AddressDal());
        UserManager userManager = new UserManager(new UserDal());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddressAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddressAdd(Address adress)
        {
            var usermail = User.Identity.Name;
            var userID = userManager.GetListAllService(x => x.UserMail == usermail).Select(y => y.UserID).FirstOrDefault();
            AddressValidator validationRules = new AddressValidator();
            ValidationResult result = validationRules.Validate(adress);
            if (result.IsValid)
            {
                adress.UserID = userID;
                addressManager.InsertService(adress);
                return RedirectToAction("Index", "Profile");
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
        public IActionResult AddressRemove(int id)
        {
            var values = addressManager.GetByIDService(id);
            addressManager.DeleteService(values);
            return RedirectToAction("Index", "Profile");
        }
        public IActionResult BasketInAddress()
        {
            var usermail = User.Identity.Name;
            var userID = userManager.GetListAllService(x => x.UserMail == usermail).Select(y => y.UserID).FirstOrDefault();
            List<SelectListItem> AddressValues = (from x in addressManager.GetListAllService(x=>x.UserID==userID)
                                                  select new SelectListItem
                                                  {
                                                      Value = x.AddressID.ToString(),
                                                      Text = x.AddressHeader.ToString()

                                                  }).ToList();
            ViewBag.ListAddress = AddressValues;
            return View();
        }
    }
}
