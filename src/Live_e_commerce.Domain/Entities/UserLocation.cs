using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class UserLocation
    {
        public Guid Id { get; set; }
        public Guid? Uid { get; set; }
        public string CurrNation { get; set; }
        public string CurrProvince { get; set; }
        public string CurrCity { get; set; }
        public string CurrDistrict { get; set; }
        public string Location { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
