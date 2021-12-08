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
    [Authorize]
    public class AdminOrderAddressDetailsController : Controller
    {
        AddressManager addressManager = new AddressManager(new AddressDal());
        AdminManager adminManager = new AdminManager(new AdminDal());
        public IActionResult Index(int id)
        {
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            if (validation == "Admin")
            {
                var values = addressManager.GetByIDService(id);
                return View(values);
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            
        }
    }
}
