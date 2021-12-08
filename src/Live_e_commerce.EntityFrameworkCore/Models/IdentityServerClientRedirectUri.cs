using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerClientRedirectUri
    {
        public Guid ClientId { get; set; }
        public string RedirectUri { get; set; }

        public virtual IdentityServerClient Client { get; set; }
    }
}
