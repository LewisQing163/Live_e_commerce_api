using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Live_e_commerce.Entities
{
    /// <summary>
    /// 购物车
    /// </summary>
   public class ShoppingCart: BasicAggregateRoot<Guid>
    {
        public string Name { get; set; }//商品名
        public int Price { get; set; }//价格
        public string Weight { get; set; }//重量
        public string Picture { get; set; }//图片
        public Guid CommodityId { get; set; }//商品表id
        public Guid UserBaseId { get; set; }//用户信息表id
        public Guid OrderId { get; set; }//订单表id
    }
}
