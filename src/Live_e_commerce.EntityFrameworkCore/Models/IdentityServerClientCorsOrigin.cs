using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerClientCorsOrigin
    {
        public Guid ClientId { get; set; }
        public string Origin { get; set; }

        public virtual IdentityServerClient Client { get; set; }
    }
}
