using Live_e_commerce.CreateUpdateDto;
using Live_e_commerce.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using static System.Net.Mime.MediaTypeNames;

namespace Live_e_commerce.Iservice
{
    /// <summary>
    /// 商品接口
    /// </summary>
    public interface ICommodityService:ICrudAppService<CommodityDto,Guid,PagedAndSortedResultRequestDto, CreateUpdateCommodityDto>,IApplicationService
    {
        /// <summary>
        /// 自定义列表接口,带分页
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CommodityDto>> GetCommodity(string key, int pagesize=6, int pageindex=1);

    }
}
