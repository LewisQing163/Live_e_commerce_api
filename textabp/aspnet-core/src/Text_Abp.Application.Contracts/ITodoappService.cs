using Live_e_commerce.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Live_e_commerce
{
    public interface ITodoappService:ICrudAppService<TodoItemDto,Guid>//IApplicationService
    {
        //添加删除列表
        //Task<List<TodoItemDto>> GetListAsync();
        //Task<States> AddAsync(TodoItemDto todoItemDto);
        //Task<States> DeleteAsync(Guid id);
    }
}
