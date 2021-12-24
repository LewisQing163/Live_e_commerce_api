using AutoMapper.Configuration;
using Live_e_commerce.CreateUpdateDto;
using Live_e_commerce.Dto;
using Live_e_commerce.Entities;
using Live_e_commerce.Iservice;
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
    public class CommodityService: CrudAppService<Commodity, CommodityDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateCommodityDto>, ICommodityService
    {
        private IRepository<Commodity, Guid> _repository;
        public CommodityService(IRepository<Commodity,Guid> repository) : base(repository) 
        {
            _repository = repository;
        }
        /// <summary>
        /// 列表实现,分页
        /// </summary>
        /// <param name="key"></param>
        /// <param name="pagesize"></param>
        /// <param name="pageindex"></param>
        /// <returns></returns>
        public async Task<IEnumerable<CommodityDto>> GetCommodity(string key, int pagesize=6, int pageindex=1)
        {
            var data = await _repository.GetListAsync();
            if (!string.IsNullOrEmpty(key))
            {
                data= data.Where(p => p.Name.Contains(key)).ToList();
            }
            //var count = data.Count();
            var a= ObjectMapper.Map<List<Commodity>, List<CommodityDto>>(data);
            var list = a.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            return list;
        }
    }
}
