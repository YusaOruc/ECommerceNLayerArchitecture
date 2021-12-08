using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concreate.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ECommerce.Controllers.AdminPanel
{
    [Authorize]
    public class AdminOrderController : Controller
    {
        OrderManager orderManager = new OrderManager(new OrderDal());
        UserManager userManager = new UserManager(new UserDal());
        AdminManager adminManager = new AdminManager(new AdminDal());
        public IActionResult Index(string p,int page=1)
        {
            List<int> userList = new List<int>();
            List<User> users = new List<User>();
            //********************
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            var values = orderManager.GetListAllService().Where(x => x.OrderStatus == true).Select(x => x.UserID).Distinct();
            if (validation == "Admin")
            {
                foreach (var item in values)
                {
                    userList.Add(Convert.ToInt32(item));
                }
                foreach (var item in userList)
                {
                    var user = userManager.GetByIDService(item);
                    users.Add(user);
                }

                if (string.IsNullOrEmpty(p))
                {
                    var userListpost = users.ToPagedList(page, 5);
                    return View(userListpost);
                }
                else
                {
                    var userListpost = users.Where(x => x.UserName.Contains(p)).ToPagedList(page, 5);
                    return View(userListpost);
                }
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            //var values2 = orderManager.GetListAllWithProductService(x=>x.OrderStatus==true).Distinct();
            //return View(values2);
            
            
        }
        public IActionResult StatusFalse(string p, int page = 1)
        {
            List<int> userList = new List<int>();
            List<User> users = new List<User>();


            var values = orderManager.GetListAllService().Where(x => x.OrderStatus == false).Select(x => x.UserID).Distinct();
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            if (validation == "Admin")
            {
                foreach (var item in values)
                {
                    userList.Add(Convert.ToInt32(item));
                }
                foreach (var item in userList)
                {
                    var user = userManager.GetByIDService(item);
                    users.Add(user);
                }

                if (string.IsNullOrEmpty(p))
                {
                    var userListpost = users.ToPagedList(page, 5);
                    return View(userListpost);
                }
                else
                {
                    var userListpost = users.Where(x => x.UserName.Contains(p)).ToPagedList(page, 5);
                    return View(userListpost);
                }
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            
        }
        public IActionResult Details(string p,int id,int page=1)
        {
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            if (validation == "Admin")
            {
                if (string.IsNullOrEmpty(p))
                {
                    var values = orderManager.GetListAllWithProductService(x => x.UserID == id).Where(x => x.OrderStatus == true).ToPagedList(page, 5);
                    return View(values);
                }
                else
                {
                    var values = orderManager.GetListAllWithProductService(x => x.UserID == id).Where(x => x.Products.ProductName.Contains(p) && x.OrderStatus == true).ToPagedList(page, 5);
                    return View(values);
                }
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            
            
             

        }
        public IActionResult FalseDetails(string p, int id, int page = 1)
        {
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            if (validation == "Admin")
            {
                if (string.IsNullOrEmpty(p))
                {
                    var values = orderManager.GetListAllWithProductService(x => x.UserID == id).Where(x => x.OrderStatus == false).ToPagedList(page, 5);
                    return View(values);
                }
                else
                {
                    var values = orderManager.GetListAllWithProductService(x => x.UserID == id).Where(x => x.Products.ProductName.Contains(p) && x.OrderStatus == false).ToPagedList(page, 5);
                    return View(values);
                }
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            



        }
        public IActionResult OrderStatus(int id)
        {
            var values = orderManager.GetListAllService(x=>x.UserID==id);
            
            foreach (var item in values)
            {
                item.OrderStatus = true;
                orderManager.UpdateService(item);
            }
            
             return RedirectToAction("StatusFalse");
           
            
        }
        public IActionResult OrderStatusFalse(int id)
        {
            var values = orderManager.GetListAllService(x => x.UserID == id);

            foreach (var item in values)
            {
                item.OrderStatus = false;
                orderManager.UpdateService(item);
            }

            return RedirectToAction("Index");

        }



    }

}






