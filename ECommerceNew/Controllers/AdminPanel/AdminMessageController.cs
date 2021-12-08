using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
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
    public class AdminMessageController : Controller
    {
        ContactManager contactManager = new ContactManager(new ContactDal());
        AdminManager adminManager = new AdminManager(new AdminDal());
        public IActionResult Index(int page = 1)
        {
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            if (validation == "Admin")
            {
                var values = contactManager.GetListAllService().ToPagedList(page, 5);
                return View(values);
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            
        }
        public IActionResult DeleteMessage(int id)
        {
            var value = contactManager.GetByIDService(id);
            contactManager.DeleteService(value);
            return RedirectToAction("Index");
        }
        public IActionResult DetailsMessage(int id)
        {
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            if (validation == "Admin")
            {
                var value = contactManager.GetByIDService(id);
                return View(value);
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            
        }
    }
}
