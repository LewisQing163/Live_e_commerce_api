using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace live.entity
{
    [Table("UserExtra")]
    public  class UserExtra : AuditedAggregateRoot<Guid>
    {
        public Guid? Uid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Extend1 { get; set; }
        public string Extend2 { get; set; }
    }
}
