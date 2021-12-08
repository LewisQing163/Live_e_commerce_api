using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class UserRegisterLog
    {
        public Guid Id { get; set; }
        public Guid? Uid { get; set; }
        public string RegisterMethod { get; set; }
        public DateTime? RegisterTime { get; set; }
    }
}
