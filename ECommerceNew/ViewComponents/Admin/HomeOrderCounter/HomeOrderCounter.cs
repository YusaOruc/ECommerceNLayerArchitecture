using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.ViewComponents.Admin.HomeOrderCounter
{
    public class HomeOrderCounter:ViewComponent
    {
        OrderManager orderManager = new OrderManager(new OrderDal());
        public IViewComponentResult Invoke()
        {

            var values = orderManager.GetListAllService().Count;
            ViewBag.orderCounter = values;
            return View();
        }
    }
}
