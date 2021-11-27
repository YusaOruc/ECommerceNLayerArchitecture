using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    public class ShoppingProductController : Controller
    {
        ProductManager productManager = new ProductManager(new ProductDal());

        
        public IActionResult Index(string p)
        {
            
            if (string.IsNullOrEmpty(p))
            {
                var values = productManager.GetListAllService();
                return View(values);
            }
            else
            {
                var values = productManager.GetListAllService(x => x.ProductName.Contains(p));
                return View(values);
            }
            
           
             
            
            
            
        }
        
        public IActionResult GetCategoryProduct(int id)
        {
           

            var values = productManager.GetListAllService(x=>x.CategoryID==id);
            return View(values);
        }
        public IActionResult Search(string p)
        {
            var values = productManager.GetListAllService(x => x.ProductName.Contains(p));
            return RedirectToAction("GetCategoryProduct", values);
        }
        public IActionResult ProductDetails(int id)
        {
            var values = productManager.GetListAllService(x=>x.ProductID==id);
            return View(values);
        }
       
    }
}
