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
            if (ModelState.IsValid)
            {
                QuoteViewModel model = new QuoteViewModel();
                model.DateRequested = DateTime.Now;
                model.GallonsRequested = 3;
                model.DeliveryAddress = "Linky drive";
                model.PricePerGallon = "10";
                model.TotalAmount = "100";
                List<QuoteViewModel> quotes = new List<QuoteViewModel>();
                quotes.Add(model);
                return View("QuoteHistory", quotes);
            }

            return View();
        }

        public bool QuoteDataValidation(QuoteViewModel model)
        {
            bool flag = false;
            if ((model.DeliveryAddress.Length <= 100) && (model.DeliveryAddress != String.Empty))
            {
                if ((model.GallonsRequested > 0) && (model.DateRequested > DateTime.Now))
                {
                    flag = true;
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
