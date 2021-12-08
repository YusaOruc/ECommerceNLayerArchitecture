using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concreate.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Controllers.AdminPanel
{
    [Authorize]
    public class AdminSliderController : Controller
    {
        SliderManager sliderManager = new SliderManager(new SliderDal());
        AdminManager adminManager = new AdminManager(new AdminDal());
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            if (validation == "Admin")
            {
                var values = sliderManager.GetListAllService();
                return View(values);
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            
        }
        [HttpGet]
        public IActionResult AddSlider()
        {
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            if (validation == "Admin")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            
        }
        [HttpPost]
        public IActionResult AddSlider(Slider slider)
        {
            sliderManager.InsertService(slider);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSlider(int id)
        {
            var values = sliderManager.GetByIDService(id);
            sliderManager.DeleteService(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            var usermail = User.Identity.Name;
            var validation = adminManager.GetListAllService(x => x.AdminName == usermail).Select(x => x.Roles).FirstOrDefault();
            if (validation == "Admin")
            {
                var value = sliderManager.GetByIDService(id);
                return View(value);
            }
            else
            {
                return RedirectToAction("Index", "AdminLogin");
            }
            
        }
        [HttpPost]
        public IActionResult UpdateSlider(Slider slider)
        {
            sliderManager.UpdateService(slider);
            return RedirectToAction("Index");
        }
    }
}
