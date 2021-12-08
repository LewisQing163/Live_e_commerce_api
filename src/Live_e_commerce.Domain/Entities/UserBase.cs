using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class UserBase
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public int? Age { get; set; }
        public int? Sex { get; set; }
        public string Hobby { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
        public string NikeName { get; set; }
        public string Sign { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
