using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class AbpRole
    {
        public AbpRole()
        {
            AbpOrganizationUnitRoles = new HashSet<AbpOrganizationUnitRole>();
            AbpRoleClaims = new HashSet<AbpRoleClaim>();
            AbpUserRoles = new HashSet<AbpUserRole>();
        }

        public Guid Id { get; set; }
        public Guid? TenantId { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public bool IsDefault { get; set; }
        public bool IsStatic { get; set; }
        public bool IsPublic { get; set; }
        public string ExtraProperties { get; set; }
        public string ConcurrencyStamp { get; set; }

        public virtual ICollection<AbpOrganizationUnitRole> AbpOrganizationUnitRoles { get; set; }
        public virtual ICollection<AbpRoleClaim> AbpRoleClaims { get; set; }
        public virtual ICollection<AbpUserRole> AbpUserRoles { get; set; }
    }
}
