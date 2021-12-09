
using Live_e_commerce;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Live_e_commerce
{
    public interface IBaseAppService<T> where T:class,new()
    {
        #region 自定义接口
        //添加删除列表
        Task<IEnumerable<T>> GetListAsync();
        Task<int> AddAsync(T model);
        Task<int> DeleteAsync(T model);
        #endregion

    }
}
