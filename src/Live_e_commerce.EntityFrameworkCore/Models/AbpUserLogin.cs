using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class AbpUserLogin
    {
        public Guid UserId { get; set; }
        public string LoginProvider { get; set; }
        public Guid? TenantId { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }

        public virtual AbpUser User { get; set; }
    }
}
