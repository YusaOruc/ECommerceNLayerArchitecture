using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concreate.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.ViewComponents.Adress
{
    public class Adress : ViewComponent
    {
        AddressManager addressManager = new AddressManager(new AddressDal());
        UserManager userManager = new UserManager(new UserDal());
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            var userID = userManager.GetListAllService(x => x.UserMail == usermail).Select(y => y.UserID).FirstOrDefault();
            var values = addressManager.GetListAllService(x=>x.UserID==userID);
            return View(values);
        }
       
    }
}
