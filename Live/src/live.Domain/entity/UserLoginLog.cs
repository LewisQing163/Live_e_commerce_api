using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace live.entity
{
    [Table("UserLoginLog")]
    public class UserLoginLog : AuditedAggregateRoot<Guid>
    {
        public int? Command { get; set; }
        public DateTime? CreateTime { get; set; }
        public Guid? Lid { get; set; }
    }
}
