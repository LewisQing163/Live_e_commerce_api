using Live_e_commerce.CreateUpdateDto;
using Live_e_commerce.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Live_e_commerce.IShoppingCart
{
    public interface IShoppingCartService: ICrudAppService<ShoppingCartDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateShoppingCartDto>
    {
    }
}
