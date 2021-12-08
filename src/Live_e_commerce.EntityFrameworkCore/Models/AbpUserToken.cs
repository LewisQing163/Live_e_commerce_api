using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class AbpUserToken
    {
        public Guid UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public Guid? TenantId { get; set; }
        public string Value { get; set; }

        public virtual AbpUser User { get; set; }
    }
}
