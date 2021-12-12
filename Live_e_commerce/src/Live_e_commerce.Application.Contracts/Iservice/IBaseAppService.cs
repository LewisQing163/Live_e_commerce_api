
using Live_e_commerce;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Live_e_commerce
{
    public interface IBaseAppService<T>:IApplicationService where T:class,new()
    {
        #region 自定义接口
        //增删改查
        Task<IEnumerable<T>> GetListAsync();
        Task<int> AddAsync(T model);
        Task<int> DeleteAsync(T model);
        Task<int> UpdateAsync(T model);
        #endregion

    }
}
