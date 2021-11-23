using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.ViewComponents.Admin.HomeProductCounter
{
    public class HomeProductCounter:ViewComponent
    {
        ProductManager productManager = new ProductManager(new ProductDal());
        public IViewComponentResult Invoke()
        {

            var values = productManager.GetListAllService().Count;
           
            ViewBag.productCounter = values;
            return View();
        }
    }
}
