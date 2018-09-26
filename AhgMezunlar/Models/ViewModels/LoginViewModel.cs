using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AhgMezunlar.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Email Zorunlu")]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Geçerli bir Email adresi giriniz.")]
        public string Email { get; set; }
        
        [Required(ErrorMessage ="Parola Zorunlu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
