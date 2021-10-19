using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MiniFacebookApp.Models
{
    public class FacebookUser : IdentityUser
    {
        public string Role { get; set; }
    }
}
