using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.ViewComponents.Shopping
{
    public class ShoppingCategory: ViewComponent
    {
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        public IViewComponentResult Invoke()
        {
            var values = categoryManager.GetListAllService();
            return View(values);
        }
    }
}
