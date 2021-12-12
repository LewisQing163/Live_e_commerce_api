using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Live_e_commerce.Entities
{
    /// <summary>
    /// 类别model
    /// </summary>
    public class Classification:AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 类别
        /// </summary>
        public string Name { get; set; }
    }
}
