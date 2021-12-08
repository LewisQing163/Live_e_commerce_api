using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerApiResourceClaim
    {
        public string Type { get; set; }
        public Guid ApiResourceId { get; set; }

        public virtual IdentityServerApiResource ApiResource { get; set; }
    }
}
