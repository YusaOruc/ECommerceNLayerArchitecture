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
    [Authorize]
    public class AdminOrderAddressDetailsController : Controller
    {
        AddressManager addressManager = new AddressManager(new AddressDal());
        public IActionResult Index(int id)
        {
            var values = addressManager.GetByIDService(id);
            return View(values);
        }
    }
}
