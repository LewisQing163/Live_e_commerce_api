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
        public States States { get; set; }//订单状态,1表示正常,2表示异常
        public string OrderRemark { get; set; }//订单表备注
    }
    
    public enum States
    {
        Normal = 1, 
        Abnormal = 2
    }

}
