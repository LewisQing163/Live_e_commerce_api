using System;
using System.Collections.Generic;
using System.Text;

namespace Live_e_commerce.CreateUpdateDto
{
    public class CreateUpdateShoppingCartDto
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
