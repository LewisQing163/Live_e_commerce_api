using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace live.entity
{
    [Table("UserBase")]
    public  class UserBase : AuditedAggregateRoot<Guid>
    {
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
