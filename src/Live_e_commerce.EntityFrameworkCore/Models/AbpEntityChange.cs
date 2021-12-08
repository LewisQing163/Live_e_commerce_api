using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class AbpEntityChange
    {
        public AbpEntityChange()
        {
            AbpEntityPropertyChanges = new HashSet<AbpEntityPropertyChange>();
        }

        public Guid Id { get; set; }
        public Guid AuditLogId { get; set; }
        public Guid? TenantId { get; set; }
        public DateTime ChangeTime { get; set; }
        public byte ChangeType { get; set; }
        public Guid? EntityTenantId { get; set; }
        public string EntityId { get; set; }
        public string EntityTypeFullName { get; set; }
        public string ExtraProperties { get; set; }

        public virtual AbpAuditLog AuditLog { get; set; }
        public virtual ICollection<AbpEntityPropertyChange> AbpEntityPropertyChanges { get; set; }
    }
}
