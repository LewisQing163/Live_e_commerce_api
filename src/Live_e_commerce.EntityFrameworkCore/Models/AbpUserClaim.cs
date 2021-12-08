using System;
using System.Collections.Generic;

#nullable disable

namespace Live_e_commerce.Models
{
    public partial class AbpUserClaim
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid? TenantId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual AbpUser User { get; set; }
    }
}
