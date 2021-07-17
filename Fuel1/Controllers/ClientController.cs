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
            if (ModelState.IsValid)
            {
                ProfileManagement profile = new ProfileManagement()
                {
                    Name = "Raj Singh",
                    Address1 = "4800 Calhoun Rd",
                    Address2 = "Building 1",
                    City = "Houston",
                    State = "TX",
                    Zipcode = "77002"
                };

                return View(profile);
            }
            return View();

        }

        public bool ProfileDataValidation(ProfileManagement profilemanage)
        {
            bool flag = false;
            if ((profilemanage.Name.Length <= 50) && (profilemanage.Name != String.Empty))
            {
                if (((profilemanage.Address1.Length <= 100) && (profilemanage.Address1 != String.Empty)) && (profilemanage.Address2.Length <= 100))
                {
                    if ((profilemanage.City.Length <= 100) && (profilemanage.City != String.Empty))
                    {
                        if (profilemanage.Zipcode.Length <= 9 && profilemanage.Zipcode.Length >= 5)
                        {
                            flag = true;
                        }
                    }
                }
            }
            else
            {
                flag = false;
            }

            return flag;
        }
    }
}
