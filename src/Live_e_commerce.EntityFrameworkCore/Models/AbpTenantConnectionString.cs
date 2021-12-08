using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class AbpTenantConnectionString
    {
        public Guid TenantId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual AbpTenant Tenant { get; set; }
    }
}
