using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFacebookApp.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Email Is Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password Is Required")]
        public string Password { get; set; }
    }
}

