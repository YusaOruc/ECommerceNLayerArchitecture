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
        public IActionResult Index()
        {
            var values = sliderManager.GetListAllService();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSlider()
        {
            return View();
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
            var value = sliderManager.GetByIDService(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSlider(Slider slider)
        {
            sliderManager.UpdateService(slider);
            return RedirectToAction("Index");
        }
    }
}
