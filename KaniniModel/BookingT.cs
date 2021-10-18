using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi1.KaniniModel
{
    public partial class BookingT
    {
        public string Id { get; set; }
        public string MovieName { get; set; }
        public int? Price { get; set; }
        public string MovieDescription { get; set; }
        public string MoviePoster { get; set; }
    }
}
