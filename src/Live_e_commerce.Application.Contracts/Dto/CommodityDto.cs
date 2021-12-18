using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Live_e_commerce.Dto
{

    public class CommodityDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Weight { get; set; }
        public string Picture { get; set; }
        public Guid Cid { get; set; }
    }
}
