using Live_e_commerce.CreateUpdateDto;
using Live_e_commerce.Dto;
using Live_e_commerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Live_e_commerce.Service
{
    /// <summary>
    /// 商品实现
    /// </summary>
    public class CommodityService: CrudAppService<Commodity, CommodityDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateCommodityDto>
    {
        public CommodityService(IRepository<Commodity,Guid> repository) : base(repository) { }
    }
}
