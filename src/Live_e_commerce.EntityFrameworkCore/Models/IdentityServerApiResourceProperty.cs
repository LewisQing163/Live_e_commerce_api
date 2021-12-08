using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class IdentityServerApiResourceProperty
    {
        public Guid ApiResourceId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public virtual IdentityServerApiResource ApiResource { get; set; }
    }
}
