using Fuel1.Models.Login;
using Fuel1.Models.QuoteViewModel;
using Fuel1.Models.ProfileManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



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

            if (model.Username == "Raj_123" && model.Password == "Qwerty!123")
            {
                return RedirectToAction("Home1", "Login");
            }
            if (ModelState.IsValid)
            {

                

                if (model.Username == "Raj_123" && model.Password=="Qwerty!123")
                {
                    return RedirectToAction("Home1", "Login");
                }


                ModelState.AddModelError(string.Empty, "Loging Failed!");

            }
            return View(model);
        }

        public async Task<IActionResult> Register(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ProfileManage", "Client");
            }
            return View();
        }
        public async Task<IActionResult> ProfileManagement(ProfileManagement profilemodel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Home1", "Login");
            }
            return View();
        }


        public IActionResult Home1()
            {
            return View("Home");
        }

        public bool RegisterDataValidation(LoginModel logininfo)
        {
            bool flag = false;
            if ((logininfo.Username.Length <= 50) && (logininfo.Username != String.Empty))
            {
                if ((Regex.IsMatch(logininfo.Username, @"^[a-zA-Z0-9]_")) && (logininfo.Username != String.Empty))
                {
                    if (Regex.IsMatch(logininfo.Password, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!$%^&*-]).{8,}$") && Regex.IsMatch(logininfo.repassword, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!$%^&*-]).{8,}$"))
                    {
                        if (logininfo.Password == logininfo.repassword)
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
