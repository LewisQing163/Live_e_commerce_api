using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerClientPostLogoutRedirectUri
    {
        public Guid ClientId { get; set; }
        public string PostLogoutRedirectUri { get; set; }

        public virtual IdentityServerClient Client { get; set; }
    }
}
