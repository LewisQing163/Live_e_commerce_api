using Live_e_commerce.CreateUpdateDto;
using Live_e_commerce.Dto;
using Live_e_commerce.Entities;
using Live_e_commerce.IShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Live_e_commerce.ShoppingCartService
{
    public class ShoppingCartService: CrudAppService<ShoppingCart, ShoppingCartDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateShoppingCartDto>, IShoppingCartService
    {
        public ShoppingCartService(IRepository<ShoppingCart, Guid> repository) : base(repository)
        {

        }
    }
}
