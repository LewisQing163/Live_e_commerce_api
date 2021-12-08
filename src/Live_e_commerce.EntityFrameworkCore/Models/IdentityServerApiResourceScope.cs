using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerApiResourceScope
    {
        public Guid ApiResourceId { get; set; }
        public string Scope { get; set; }

        public virtual IdentityServerApiResource ApiResource { get; set; }
    }
}
