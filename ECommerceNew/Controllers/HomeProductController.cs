using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concreate.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    
    public class HomeProductController : Controller
    {
        ProductManager productManager = new ProductManager(new  ProductDal());
        
        //[Authorize]
        public IActionResult Index()
        {
           
            var values = productManager.GetListAllService();
            return View(values);
        }
    }
}
