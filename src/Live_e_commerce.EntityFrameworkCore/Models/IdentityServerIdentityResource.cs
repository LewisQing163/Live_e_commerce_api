using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerIdentityResource
    {
        public IdentityServerIdentityResource()
        {
            IdentityServerIdentityResourceClaims = new HashSet<IdentityServerIdentityResourceClaim>();
            IdentityServerIdentityResourceProperties = new HashSet<IdentityServerIdentityResourceProperty>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public bool Required { get; set; }
        public bool Emphasize { get; set; }
        public bool ShowInDiscoveryDocument { get; set; }
        public string ExtraProperties { get; set; }
        public string ConcurrencyStamp { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid? CreatorId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public Guid? LastModifierId { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeleterId { get; set; }
        public DateTime? DeletionTime { get; set; }

        public virtual ICollection<IdentityServerIdentityResourceClaim> IdentityServerIdentityResourceClaims { get; set; }
        public virtual ICollection<IdentityServerIdentityResourceProperty> IdentityServerIdentityResourceProperties { get; set; }
    }
}
