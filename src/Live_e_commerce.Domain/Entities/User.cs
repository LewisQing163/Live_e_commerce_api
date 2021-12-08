using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public DateTime? LoginTime { get; set; }
    }
}
