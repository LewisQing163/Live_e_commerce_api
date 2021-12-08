using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerApiScopeProperty
    {
        public Guid ApiScopeId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public virtual IdentityServerApiScope ApiScope { get; set; }
    }
}
