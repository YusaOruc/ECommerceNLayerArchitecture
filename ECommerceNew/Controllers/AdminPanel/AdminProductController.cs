using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index(string p,int page=1)
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
        public IActionResult DeleteProduct(int id)
        {
            var values = productManager.GetByIDService(id);
            productManager.DeleteService(values);
            return RedirectToAction("Index");
        }
    }
}
