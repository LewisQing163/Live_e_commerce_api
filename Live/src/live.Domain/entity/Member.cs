using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace live.entity
{
    [Table("Member")]
    public class Member: AuditedAggregateRoot<Guid>
    {
        public string MemberName { get; set; }
        public Guid Uid { get; set; }
        
    }
}
