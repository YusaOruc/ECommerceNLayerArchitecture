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
    public class AdminProductController : Controller
    {
        ProductManager productManager = new ProductManager(new ProductDal());
        AdminManager adminManager = new AdminManager(new AdminDal());
        Context context = new Context();
        public IActionResult Index(string p,int page=1)
        {
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            if (validation == "Admin")
            {
                if (string.IsNullOrEmpty(p))
                {
                    var values = productManager.GetListAllWithCategory().ToPagedList(page, 5);
                    return View(values);
                }
                else
                {
                    var values = productManager.GetListAllWithCategory(x => x.ProductName.Contains(p)).ToPagedList(page, 5);
                    return View(values);
                }
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            
            
        }
        public IActionResult DeleteProduct(int id)
        {
            var values = productManager.GetByIDService(id);
            productManager.DeleteService(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var data = context.Products.Include(x => x.Category).SingleOrDefault(x => x.ProductID == id);
            var values = productManager.GetByIDService(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            productManager.UpdateService(product);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            productManager.InsertService(product);
            return RedirectToAction("Index");
        }
    }
}
