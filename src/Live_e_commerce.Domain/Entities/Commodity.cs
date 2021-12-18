using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Live_e_commerce.Entities
{
    /// <summary>
    /// 商品表
    /// </summary>
    public class Commodity:AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Weight { get; set; }
        public string Picture { get; set; }
        public Guid Cid { get; set; }
        //public int State { get; set; }

    }
}
