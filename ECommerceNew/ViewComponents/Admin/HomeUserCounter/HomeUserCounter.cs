using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.ViewComponents.Admin.HomeUserCounter
{
    public class HomeUserCounter:ViewComponent
    {
        UserManager userManager = new UserManager(new UserDal());
        public IViewComponentResult Invoke()
        {

            var values = userManager.GetListAllService().Count;
            ViewBag.userCounter = values;
            return View();
        }
    }
}
