using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fuel1.Models.QuoteViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FuelQuoteApp.Controllers
{
    public class QuoteController : Controller
    {
        [HttpGet]
        public IActionResult GetQuote()
        {
            QuoteViewModel quote = new QuoteViewModel();
            quote.DeliveryAddress = "4045 Linkwood Drive";
            quote.PricePerGallon = "100";
            return View("QuoteGenerator",quote);
        }

        public IActionResult GetQuote1(QuoteViewModel model)
        {
            
            return View("QuoteGenerator", model);
        }

        [HttpGet]
        public IActionResult QuoteHistory()
        {
            QuoteViewModel quote = new QuoteViewModel()
            {
                DateRequested = DateTime.Now.ToString(),
                GallonsRequested = "90",
                DeliveryAddress = "Linkwood Drive",
                PricePerGallon = "2",
                TotalAmount = "1500"
            };
            List<QuoteViewModel> quotes = new List<QuoteViewModel>();
            quotes.Add(quote);

            return View(quotes);
        }
    }
}