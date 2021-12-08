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
    public class AdminCategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        ProductManager productManager = new ProductManager(new ProductDal());
        AdminManager adminManager = new AdminManager(new AdminDal());
        public IActionResult Index(int page=1)
        {
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            if (validation == "Admin")
            {
                var values = categoryManager.GetListAllService().ToPagedList(page, 5);
                return View(values);
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            if (validation == "Admin")
            {
               
                return View();
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            CategoryValidator validationRules = new CategoryValidator();
            ValidationResult result = validationRules.Validate(category);
            if (result.IsValid)
            {
                categoryManager.InsertService(category);
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
        public IActionResult DeleteCategory(int id)
        {
            var values = productManager.GetListAllService(x=>x.CategoryID==id);
            if (values.Count == 0)
            {
                ViewBag.dontDelete = "";
                
                var category = categoryManager.GetByIDService(id);
                categoryManager.DeleteService(category);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.dontDelete = "Kategoriyi silmek için ona bağlı olan ürünlerin kategorisini değiştirin veya silin.";
                //System.Threading.Thread.Sleep(2000);
                return RedirectToAction("Index");
            }
              
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            if (validation == "Admin")
            {

                var values = categoryManager.GetByIDService(id);
                return View(values);
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            CategoryValidator validationRules = new CategoryValidator();
            ValidationResult result = validationRules.Validate(category);
            if(result.IsValid)
            {
                categoryManager.UpdateService(category);
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
