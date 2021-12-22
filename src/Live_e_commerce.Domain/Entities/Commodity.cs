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
        public string Name { get; set; }//商品名
        public int Price { get; set; }//价格
        public string Weight { get; set; }//重量
        public string Picture { get; set; }//图片
        public Guid ClassificationId { get; set; }//分类表id
        public Guid SpecificationId { get; set; }//规格表id
        public Guid OrderId { get; set; }//订单id
    }
}
