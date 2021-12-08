using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class AbpOrganizationUnit
    {
        public AbpOrganizationUnit()
        {
            AbpOrganizationUnitRoles = new HashSet<AbpOrganizationUnitRole>();
            AbpUserOrganizationUnits = new HashSet<AbpUserOrganizationUnit>();
            InverseParent = new HashSet<AbpOrganizationUnit>();
        }

        public Guid Id { get; set; }
        public Guid? TenantId { get; set; }
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public string DisplayName { get; set; }
        public string ExtraProperties { get; set; }
        public string ConcurrencyStamp { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid? CreatorId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public Guid? LastModifierId { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeleterId { get; set; }
        public DateTime? DeletionTime { get; set; }

        public virtual AbpOrganizationUnit Parent { get; set; }
        public virtual ICollection<AbpOrganizationUnitRole> AbpOrganizationUnitRoles { get; set; }
        public virtual ICollection<AbpUserOrganizationUnit> AbpUserOrganizationUnits { get; set; }
        public virtual ICollection<AbpOrganizationUnit> InverseParent { get; set; }
    }
}
