using System;

namespace MiniFacebookApp.Contracts.Requests
{
    public class GetLikesByDateRequest
    {
        public int PostId { get; set; }
        public DateTime Date { get; set; }
    }
}
