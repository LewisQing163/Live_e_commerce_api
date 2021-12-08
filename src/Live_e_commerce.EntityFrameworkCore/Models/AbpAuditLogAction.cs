﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class AbpAuditLogAction
    {
        public Guid Id { get; set; }
        public Guid? TenantId { get; set; }
        public Guid AuditLogId { get; set; }
        public string ServiceName { get; set; }
        public string MethodName { get; set; }
        public string Parameters { get; set; }
        public DateTime ExecutionTime { get; set; }
        public int ExecutionDuration { get; set; }
        public string ExtraProperties { get; set; }

        public virtual AbpAuditLog AuditLog { get; set; }
    }
}
