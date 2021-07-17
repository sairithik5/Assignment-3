using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fuel1.Models.QuoteViewModel;

namespace Fuel1.Controllers
{
    public class QuoteController : Controller

    {
        public IActionResult GetQuote()
        {
            return View("QuoteGenerator");
        }
        public IActionResult ShowHistory()
        {
            QuoteViewModel model = new QuoteViewModel();
            model.DateRequested = DateTime.Now.ToString();
            model.GallonsRequested = "3";
            model.DeliveryAddress = "Linky drive";
            model.PricePerGallon = "10";
            model.TotalAmount = "100";
            List<QuoteViewModel> quotes = new List<QuoteViewModel>();

            return View("QuoteHistory",quotes);
        }
    }
}
