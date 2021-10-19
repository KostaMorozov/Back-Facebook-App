using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFacebookApp.Models
{
    public class Post
    {
        [Key] 
        public int PostId { get; set; }
        [Required(ErrorMessage = "Header Is Required")]
        public string Header { get; set; }
        [Required(ErrorMessage = "Description Is Required")]
        public string Description { get; set; }

        public string UserId { get; set; }
    }
}
