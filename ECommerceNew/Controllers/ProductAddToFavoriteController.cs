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
    public class ProductAddToFavoriteController : Controller
    {
        FavProductManager favProductManager = new FavProductManager(new FavProductDal());
        ProductManager productManager = new ProductManager(new ProductDal());
        UserManager userManager = new UserManager(new UserDal());
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            var userID = userManager.GetListAllService(x => x.UserMail == usermail).Select(y => y.UserID).FirstOrDefault();
            List<Product> productList = new List<Product>();
            var values = favProductManager.GetListAllService(x => x.UserID == userID);
            foreach (var item in values)
            {
                var favProduct = productManager.GetByIDService(item.SelectedFavProductID);
                productList.Add(favProduct);

            }
            return View(productList.ToList());
            
        }
        public IActionResult ProductFavorite(int id)
        {
            var usermail = User.Identity.Name;
            var userID = userManager.GetListAllService(x => x.UserMail == usermail).Select(y => y.UserID).FirstOrDefault();
            FavProduct favProduct = new FavProduct();
            favProduct.UserID = userID;
            favProduct.SelectedFavProductID = id;
            favProductManager.InsertService(favProduct);
            return RedirectToAction("Index", "ProductAddToFavorite");
        }
        public IActionResult ProductFavoriteDelete(int id)
        {
            var values = favProductManager.GetByProductIDService(id);
            var find = favProductManager.GetByIDService(values);
            favProductManager.DeleteService(find);
            return RedirectToAction("Index", "ProductAddToFavorite");
        }
        
    }
}
