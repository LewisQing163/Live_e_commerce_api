using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class Consumption
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public int? ProductPrice { get; set; }
        public Guid? Bid { get; set; }
    }
}
