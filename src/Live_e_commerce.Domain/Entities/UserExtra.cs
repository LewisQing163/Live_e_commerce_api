using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class UserExtra
    {
        public Guid Id { get; set; }
        public Guid? Uid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Extend1 { get; set; }
        public string Extend2 { get; set; }
    }
}
