using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace live.entity
{
    [Table("UserInfoUpdate")]
    public  class UserInfoUpdate : AuditedAggregateRoot<Guid>
    {
        public string AttributeOldVal { get; set; }
        public string AttributeNewVal { get; set; }
        public DateTime? UpdateTime { get; set; }
        public Guid? Uid { get; set; }
    }
}
