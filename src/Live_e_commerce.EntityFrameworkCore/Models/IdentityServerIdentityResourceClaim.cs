using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerIdentityResourceClaim
    {
        public string Type { get; set; }
        public Guid IdentityResourceId { get; set; }

        public virtual IdentityServerIdentityResource IdentityResource { get; set; }
    }
}
