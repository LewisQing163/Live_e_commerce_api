using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerApiScope
    {
        public IdentityServerApiScope()
        {
            IdentityServerApiScopeClaims = new HashSet<IdentityServerApiScopeClaim>();
            IdentityServerApiScopeProperties = new HashSet<IdentityServerApiScopeProperty>();
        }

        public Guid Id { get; set; }
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
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

        public virtual ICollection<IdentityServerApiScopeClaim> IdentityServerApiScopeClaims { get; set; }
        public virtual ICollection<IdentityServerApiScopeProperty> IdentityServerApiScopeProperties { get; set; }
    }
}
