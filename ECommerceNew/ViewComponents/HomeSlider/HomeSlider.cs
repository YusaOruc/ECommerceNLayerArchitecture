using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.ViewComponents.HomeSlider
{
    public class HomeSlider:ViewComponent
    {
        SliderManager sliderManager = new SliderManager(new SliderDal());
        public IViewComponentResult Invoke()
        {
            var values = sliderManager.GetListAllService();
            return View(values);
        }
    }
}
