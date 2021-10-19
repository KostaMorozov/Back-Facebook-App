using System;

namespace MiniFacebookApp.Models
{
    public class Like
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }
        public int PostId { get; set; }
    }
}
