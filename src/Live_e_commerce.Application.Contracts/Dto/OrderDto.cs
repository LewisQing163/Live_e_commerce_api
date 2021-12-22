using System;
using System.Collections.Generic;
using System.Text;

namespace Live_e_commerce.Dto
{
    public class OrderDto:Volo.Abp.Application.Dtos.AuditedEntityDto<Guid>
    {
        public int OrderNumber { get; set; }//订单编号
        public States States { get; set; }//订单状态,1表示正常,2表示异常
        public string OrderRemark { get; set; }//订单表备注
    }
}
