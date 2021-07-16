using Fuel1.Models.Login;
using Fuel1.Models.ProfileManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Fuel1.Controllers
{
    public class LoginController : Controller
    {
        
        public IActionResult LoginView()
        {
            return View("LoginView");
        }

        public ActionResult RegisterView()
        {
            return View("Register");
        }

        public async Task<IActionResult> Login(LoginModel model)
        {

            if (model.Email == "Raj_123" && model.Password == "Qwerty!123")
            {
                return RedirectToAction("Home1", "Login");
            }
            if (ModelState.IsValid)
            {

                

                if (model.Email=="Raj_123" && model.Password=="Qwerty!123")
                {
                    return RedirectToAction("Home1", "Login");
                }


                ModelState.AddModelError(string.Empty, "Loging Failed!");

            }
            return View(model);
        }

        public async Task<IActionResult> Register(LoginModel model)
        {
            return RedirectToAction("ProfileManage", "Client");
        }
        public async Task<IActionResult> ProfileManagement(ProfileManagement model)
        {
            return RedirectToAction("Home1", "Login");
        }


        public IActionResult Home1()
            {
            return View("Home");
        }

        

    }
}
