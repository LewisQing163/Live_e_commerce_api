using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class AbpUserRole
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public Guid? TenantId { get; set; }

        public virtual AbpRole Role { get; set; }
        public virtual AbpUser User { get; set; }
    }
}
