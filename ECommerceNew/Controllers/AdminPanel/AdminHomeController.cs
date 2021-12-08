using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Controllers.AdminPanel
{
    public class AdminHomeController : Controller
    {
        SliderManager sliderManager = new SliderManager(new SliderDal());
        AdminManager adminManager = new AdminManager(new AdminDal());
        [Authorize]
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            if (validation == "Admin")
            {
                var values = sliderManager.GetListAllService();
                return View(values);
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            
        }
    }
}
