using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class UserInfoUpdate
    {
        public Guid Id { get; set; }
        public string AttributeOldVal { get; set; }
        public string AttributeNewVal { get; set; }
        public DateTime? UpdateTime { get; set; }
        public Guid? Uid { get; set; }
    }
}
