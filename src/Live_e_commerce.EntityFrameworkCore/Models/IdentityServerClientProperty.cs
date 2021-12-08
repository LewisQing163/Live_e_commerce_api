using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerClientProperty
    {
        public Guid ClientId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public virtual IdentityServerClient Client { get; set; }
    }
}
