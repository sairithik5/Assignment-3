using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fuel1.Models.Login
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is required!")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Re-enter of password is required!")]
        [DataType(DataType.Password)]
        public string repassword { get; set; }
    }
}
