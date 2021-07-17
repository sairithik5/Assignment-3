using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fuel1.Models.ProfileManagement
{
    public class ProfileManagement
    {
        [Required(ErrorMessage = "Full Name is required!")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address1 is required!")]
        [DataType(DataType.Text)]
        public string Address1 { get; set; }

        [Required(ErrorMessage = "Address2 is required!")]
        [DataType(DataType.Text)]
        public string Address2 { get; set; }

        [Required(ErrorMessage = "City is required!")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required!")]
        [DataType(DataType.Text)]
        public string State { get; set; }

        [Required(ErrorMessage = "ZipCode is required!")]
        [DataType(DataType.PostalCode)]
        public string Zipcode { get; set; }

    }
}
