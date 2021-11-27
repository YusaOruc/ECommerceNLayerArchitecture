using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concreate.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    public class ProductAddToBasket : Controller
    {
        BasketProductManager basketProductManager = new BasketProductManager(new BasketProductDal());
        UserManager userManager = new UserManager(new UserDal());
        ProductManager productManager = new ProductManager(new ProductDal());
        

        public IActionResult Index(int id)
        {
            
            var product = productManager.GetByIDService(id);
            var usermail = User.Identity.Name;
            
            var userID = userManager.GetListAllService(x => x.UserMail == usermail).Select(y => y.UserID).FirstOrDefault();

            SetCookie("product", product.ProductID.ToString());

            basketProductManager.BasketProductInsertService(product,userID);
            return RedirectToAction("Index", "ShoppingProduct");
            
        }
        public IActionResult ProductBasket()
        {
            var usermail = User.Identity.Name;
            var userID = userManager.GetListAllService(x => x.UserMail == usermail).Select(y => y.UserID).FirstOrDefault();
            var values = basketProductManager.GetListAllService(x=>x.UserID==userID);
            ViewBag.cookie=GetCookie("product");
           
            return View(values);
            
        }
        public IActionResult ProductDelete(int id)
        {
            
            
            var values = basketProductManager.GetByProductIDService(id);
            var find = basketProductManager.GetByIDService(values);
            basketProductManager.DeleteService(find);
            return RedirectToAction("ProductBasket", "ProductAddToBasket");
        }
        public IActionResult BasketProductNumberAdd(int id)
        {
            var values = basketProductManager.GetByIDService(id);
            var number = values.BasketProductNumber;
            values.BasketProductNumber = number + 1;
            basketProductManager.UpdateService(values);
            

            return RedirectToAction("ProductBasket", "ProductAddToBasket");
        }
        public IActionResult BasketProductNumberDelete(int id)
        {
            var values = basketProductManager.GetByIDService(id);
            var number = values.BasketProductNumber;
            
            if (number > 1)
            {
                values.BasketProductNumber= number - 1;
            }
            
            basketProductManager.UpdateService(values);

            return RedirectToAction("ProductBasket", "ProductAddToBasket");
        }
        //Cookie------------------------
        public void SetCookie(string key, string value)
        {
            HttpContext.Response.Cookies.Append(key, value);
           
        }
        public string GetCookie(string key)
        {
           
            HttpContext.Request.Cookies.TryGetValue(key, out string value);
             
            
            return value;
        }
    }
}
