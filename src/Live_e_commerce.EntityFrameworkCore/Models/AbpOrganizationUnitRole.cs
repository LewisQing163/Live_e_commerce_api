using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class AbpOrganizationUnitRole
    {
        public Guid RoleId { get; set; }
        public Guid OrganizationUnitId { get; set; }
        public Guid? TenantId { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid? CreatorId { get; set; }

        public virtual AbpOrganizationUnit OrganizationUnit { get; set; }
        public virtual AbpRole Role { get; set; }
    }
}
