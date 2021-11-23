using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Controllers.AdminPanel
{
    public class AdminHomeController : Controller
    {
        SliderManager sliderManager = new SliderManager(new SliderDal());
        [Authorize]
        public IActionResult Index()
        {
            var values = sliderManager.GetListAllService();
            return View(values);
        }
    }
}
