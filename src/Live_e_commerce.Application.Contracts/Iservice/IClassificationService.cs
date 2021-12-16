using Live_e_commerce.CreateUpdateDto;
using Live_e_commerce.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Live_e_commerce.Iservice
{
    /// <summary>
    /// 商品分类接口
    /// </summary>
    public interface IClassificationService:ICrudAppService<ClassificationDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateClassificationDto>
    {

    }
}
