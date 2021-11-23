using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.ViewComponents.Admin.HomeCategoryCounter
{
    public class HomeCategoryCounter:ViewComponent
    {
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        public IViewComponentResult Invoke()
        {

            var values = categoryManager.GetListAllService().Count;
            ViewBag.categoryCounter = values;
            return View();
        }
    }
}
