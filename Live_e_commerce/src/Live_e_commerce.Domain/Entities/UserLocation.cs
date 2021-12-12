using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Live_e_commerce.Entities
{
    [Table("UserLocation")]
    public  class UserLocation : AuditedAggregateRoot<Guid>
    {
        public Guid? Uid { get; set; }
        public string CurrNation { get; set; }
        public string CurrProvince { get; set; }
        public string CurrCity { get; set; }
        public string CurrDistrict { get; set; }
        public string Location { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
