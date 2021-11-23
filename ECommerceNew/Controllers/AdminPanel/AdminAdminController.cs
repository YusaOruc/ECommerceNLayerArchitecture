using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.AdminPanel;
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

namespace ECommerce.Controllers.AdminPanel
{
    [Authorize]
    public class AdminAdminController : Controller
    {
        AdminManager adminManager = new AdminManager(new AdminDal());
        public IActionResult Index(int page=1)
        {
            var values = adminManager.GetListAllService().ToPagedList(page, 5);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAdmin(Admin admin)
        {
            AdminValidator validationRules = new AdminValidator();
            ValidationResult result = validationRules.Validate(admin);
            if (result.IsValid)
            {
                adminManager.InsertService(admin);
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

        public IActionResult DeleteAdmin(int id)
        {
            var values = adminManager.GetByIDService(id);
            adminManager.DeleteService(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAdmin(int id)
        {
            var values = adminManager.GetByIDService(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAdmin(Admin admin)
        {
            AdminValidator validationRules = new AdminValidator();
            ValidationResult result = validationRules.Validate(admin);
            if(result.IsValid)
            {
                adminManager.UpdateService(admin);
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
    }
}
