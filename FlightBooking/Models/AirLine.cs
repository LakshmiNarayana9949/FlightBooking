using System;
using System.Collections.Generic;

#nullable disable

namespace FlightBooking.Models
{
    public partial class AirLine
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? ContactNumber { get; set; }
        public string Address { get; set; }
    }
}
