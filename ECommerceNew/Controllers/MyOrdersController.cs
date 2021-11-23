using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ECommerce.Controllers
{
    public class MyOrdersController : Controller
    {
        OrderManager orderManager = new OrderManager(new OrderDal());
        UserManager userManager = new UserManager(new UserDal());
        public IActionResult Index(int page = 1)
        {
            var usermail = User.Identity.Name;
            var userID = userManager.GetListAllService(x => x.UserMail == usermail).Select(y => y.UserID).FirstOrDefault();
            var values = orderManager.GetListAllWithProductService(x=>x.UserID==userID).ToPagedList(page, 5); ;
            return View(values);
        }
    }
}
