using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerApiScopeClaim
    {
        public string Type { get; set; }
        public Guid ApiScopeId { get; set; }

        public virtual IdentityServerApiScope ApiScope { get; set; }
    }
}
