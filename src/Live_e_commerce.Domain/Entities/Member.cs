using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class Member
    {
        public Guid Id { get; set; }
        public string MemberName { get; set; }
        public Guid Uid { get; set; }
    }
}
