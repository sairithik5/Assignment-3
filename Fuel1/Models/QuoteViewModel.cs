using System;
using System.ComponentModel.DataAnnotations;
namespace Fuel1.Models.QuoteViewModel
{
    public class QuoteViewModel
    {

        [Required(ErrorMessage = "Gallons Requested is required!")]
        [DataType(DataType.Text)]
        public string GallonsRequested { get; set; }

        [Required(ErrorMessage = "Delivery Address is required!")]
        [DataType(DataType.Text)]
        public string DeliveryAddress { get; set; }

        [Required(ErrorMessage = "Date Requested is required!")]
        [DataType(DataType.Text)]
        public string DateRequested { get; set; }

        [Required(ErrorMessage = "Price Per Gallon is required!")]
        [DataType(DataType.Text)]
        public string PricePerGallon { get; set; }

        [Required(ErrorMessage = "Total Amount Due is required!")]
        [DataType(DataType.Text)]
        public string TotalAmount { get; set; }



    }
}
