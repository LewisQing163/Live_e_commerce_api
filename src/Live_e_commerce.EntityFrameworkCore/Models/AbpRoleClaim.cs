using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class AbpRoleClaim
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public Guid? TenantId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual AbpRole Role { get; set; }
    }
}
