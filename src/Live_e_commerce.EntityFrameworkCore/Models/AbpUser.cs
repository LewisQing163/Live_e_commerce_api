using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class AbpUser
    {
        public AbpUser()
        {
            AbpUserClaims = new HashSet<AbpUserClaim>();
            AbpUserLogins = new HashSet<AbpUserLogin>();
            AbpUserOrganizationUnits = new HashSet<AbpUserOrganizationUnit>();
            AbpUserRoles = new HashSet<AbpUserRole>();
            AbpUserTokens = new HashSet<AbpUserToken>();
        }

        public Guid Id { get; set; }
        public Guid? TenantId { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool? EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public bool? IsExternal { get; set; }
        public string PhoneNumber { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
        public bool? TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool? LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string ExtraProperties { get; set; }
        public string ConcurrencyStamp { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid? CreatorId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public Guid? LastModifierId { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeleterId { get; set; }
        public DateTime? DeletionTime { get; set; }

        public virtual ICollection<AbpUserClaim> AbpUserClaims { get; set; }
        public virtual ICollection<AbpUserLogin> AbpUserLogins { get; set; }
        public virtual ICollection<AbpUserOrganizationUnit> AbpUserOrganizationUnits { get; set; }
        public virtual ICollection<AbpUserRole> AbpUserRoles { get; set; }
        public virtual ICollection<AbpUserToken> AbpUserTokens { get; set; }
    }
}
