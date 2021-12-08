using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerApiResourceSecret
    {
        public string Type { get; set; }
        public string Value { get; set; }
        public Guid ApiResourceId { get; set; }
        public string Description { get; set; }
        public DateTime? Expiration { get; set; }

        public virtual IdentityServerApiResource ApiResource { get; set; }
    }
}
