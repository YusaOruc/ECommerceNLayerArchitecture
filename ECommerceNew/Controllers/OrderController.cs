using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concreate.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    public class OrderController : Controller
    {
        
        OrderManager orderManager = new OrderManager(new OrderDal());
        BasketProductManager basketProductManager = new BasketProductManager(new BasketProductDal());
        UserManager userManager = new UserManager(new UserDal());
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddOrder(Address address)
        {
            
            Order order = new Order();
            var usermail = User.Identity.Name;
            var userID = userManager.GetListAllService(x => x.UserMail == usermail).Select(y => y.UserID).FirstOrDefault();

            var value = basketProductManager.GetListAllService(x=>x.UserID==userID);

            foreach (var item in value)
            {
                
                order.OrderID = 0;
                order.OrderStatus = true;
                order.UserID = item.UserID;
                order.ProductID = item.SelectedBasketProductID;
                order.ProductNumber = item.BasketProductNumber;
                //order.BasketProductID = item.BasketProductID.ToString();
                order.AddressID = address.AddressID;
                
                orderManager.InsertService(order);
                basketProductManager.DeleteService(item);
            }
            System.Threading.Thread.Sleep(2000);
            return RedirectToAction("Index", "HomeProduct");
        }
    }
}
