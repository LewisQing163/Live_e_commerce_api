using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerClientScope
    {
        public Guid ClientId { get; set; }
        public string Scope { get; set; }

        public virtual IdentityServerClient Client { get; set; }
    }
}
