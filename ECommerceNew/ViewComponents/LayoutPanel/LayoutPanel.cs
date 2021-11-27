using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.ViewComponents.LayoutPanel
{
    public class LayoutPanel : ViewComponent
    {
        BasketProductManager basketProductManager = new BasketProductManager(new BasketProductDal());
        FavProductManager favProductManager = new FavProductManager(new FavProductDal());
        UserManager userManager = new UserManager(new UserDal());
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            var userID = userManager.GetListAllService(x => x.UserMail == usermail).Select(y => y.UserID).FirstOrDefault();
            
            ViewBag.basketNumber = basketProductManager.GetListAllService(x => x.UserID == userID).Count();
            ViewBag.favNumber = favProductManager.GetListAllService(x => x.UserID == userID).Count();

            return View();
        }
    }
}
