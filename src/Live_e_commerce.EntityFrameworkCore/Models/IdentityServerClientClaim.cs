using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerClientClaim
    {
        public Guid ClientId { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

        public virtual IdentityServerClient Client { get; set; }
    }
}
