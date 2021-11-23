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
        public IActionResult Index(int page = 1)
        {
            var values = contactManager.GetListAllService().ToPagedList(page, 5);
            return View(values);
        }
        public IActionResult DeleteMessage(int id)
        {
            var value = contactManager.GetByIDService(id);
            contactManager.DeleteService(value);
            return RedirectToAction("Index");
        }
        public IActionResult DetailsMessage(int id)
        {
            var value = contactManager.GetByIDService(id);
            return View(value);
        }
    }
}
