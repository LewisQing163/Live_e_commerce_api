using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace live.entity
{
    [Table("User")]
    public  class User : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string PassWord { get; set; }
        public DateTime? LoginTime { get; set; }
    }
}
