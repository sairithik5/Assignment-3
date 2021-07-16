using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fuel1.Models.ProfileManagement;

namespace Fuel1.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult ProfileManage()
        {
            return View("ProfileManagement");
        }


        public IActionResult ViewProfile()
        {
            ProfileManagement profile = new ProfileManagement()
            {
                Name = "Raj Singh",
                Address1 = "4800 Calhoun Rd",
                Address2 = "Building 1",
                City = "Houston",
                State = "TX",
                Zipcode = 77002
            };
            
            return View(profile);
        }
    }
}
