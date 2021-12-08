using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerIdentityResourceProperty
    {
        public Guid IdentityResourceId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public virtual IdentityServerIdentityResource IdentityResource { get; set; }
    }
}
