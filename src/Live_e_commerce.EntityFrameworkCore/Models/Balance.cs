using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class Balance
    {
        public Guid Id { get; set; }
        public int? Balance1 { get; set; }
        public Guid? Uid { get; set; }
    }
}
