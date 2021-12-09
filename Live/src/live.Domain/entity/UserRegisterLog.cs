using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace live.entity
{
    [Table("UserRegisterLog")]
    public  class UserRegisterLog : AuditedAggregateRoot<Guid>
    {
        public Guid? Uid { get; set; }
        public string RegisterMethod { get; set; }
        public DateTime? RegisterTime { get; set; }
    }
}
