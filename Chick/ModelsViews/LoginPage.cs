using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Chick.ModelsViews
{
    public class LoginPage
    {
        [Required(ErrorMessage = "Wpisz swój adres mailowy")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "E-mail nie jest prawidłowy")]
        [Display(Name = "E-mail:")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Wpisz swoje hasło")]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło:")]
        public string Password { get; set; }
    }
}