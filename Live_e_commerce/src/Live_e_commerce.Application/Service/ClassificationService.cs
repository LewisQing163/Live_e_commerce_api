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
    /// 类别实现
    /// </summary>
    public class ClassificationService : CrudAppService<Classification,ClassificationDto,Guid, PagedAndSortedResultRequestDto,CreateUpdateClassificationDto>,IClassificationService
    {
        public ClassificationService(IRepository<Classification,Guid> respository) : base(respository) { }
    }
}
