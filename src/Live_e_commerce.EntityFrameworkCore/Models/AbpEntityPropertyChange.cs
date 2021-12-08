﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class AbpEntityPropertyChange
    {
        public Guid Id { get; set; }
        public Guid? TenantId { get; set; }
        public Guid EntityChangeId { get; set; }
        public string NewValue { get; set; }
        public string OriginalValue { get; set; }
        public string PropertyName { get; set; }
        public string PropertyTypeFullName { get; set; }

        public virtual AbpEntityChange EntityChange { get; set; }
    }
}
