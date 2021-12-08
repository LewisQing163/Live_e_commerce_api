using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerApiResource
    {
        public IdentityServerApiResource()
        {
            IdentityServerApiResourceClaims = new HashSet<IdentityServerApiResourceClaim>();
            IdentityServerApiResourceProperties = new HashSet<IdentityServerApiResourceProperty>();
            IdentityServerApiResourceScopes = new HashSet<IdentityServerApiResourceScope>();
            IdentityServerApiResourceSecrets = new HashSet<IdentityServerApiResourceSecret>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public string AllowedAccessTokenSigningAlgorithms { get; set; }
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

        public virtual ICollection<IdentityServerApiResourceClaim> IdentityServerApiResourceClaims { get; set; }
        public virtual ICollection<IdentityServerApiResourceProperty> IdentityServerApiResourceProperties { get; set; }
        public virtual ICollection<IdentityServerApiResourceScope> IdentityServerApiResourceScopes { get; set; }
        public virtual ICollection<IdentityServerApiResourceSecret> IdentityServerApiResourceSecrets { get; set; }
    }
}
