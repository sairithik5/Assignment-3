﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fuel1.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult ProfileManage()
        {
            return View("ProfileManagement");
        }
    }
}
