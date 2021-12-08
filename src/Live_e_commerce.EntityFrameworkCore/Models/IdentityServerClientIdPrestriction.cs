using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerClientIdPrestriction
    {
        public Guid ClientId { get; set; }
        public string Provider { get; set; }

        public virtual IdentityServerClient Client { get; set; }
    }
}
