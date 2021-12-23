using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Live_e_commerce.Entities
{
    /// <summary>
    /// 订单表
    /// </summary>
    [Table("Order")]
    public class Order:BasicAggregateRoot<Guid>
    {
        public int OrderNumber { get; set; }//订单编号
        public States States { get; set; }//订单状态
        public string OrderRemark { get; set; }//订单表备注
    }
    
    public enum States
    {
        Submit=1,//订但提交成功
        PaymentSuccessful=2,//支付成功
        Unpaid=4,//多久时间内未支付
        CancelOrder=8,//订单取消
    }

}
