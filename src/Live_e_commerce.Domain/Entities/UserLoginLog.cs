using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class UserLoginLog
    {
        public Guid Id { get; set; }
        public int? Command { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? Lid { get; set; }
    }
}
