
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Live_e_commerce.EntityFrameworkCore;

namespace Live_e_commerce
{
    public class BaseAppService<T> :IBaseAppService<T> where T:class,new()
    {
        #region 自定义实现接口
        private readonly Live_e_commerceDbContext _context;
        public BaseAppService(Live_e_commerceDbContext context)
        {
            _context = context;
        }


        public async Task<int> AddAsync(T model)
        {
            await _context.AddAsync(model);
            return 200;
        }

        public async Task<int> DeleteAsync(T model)
        {
            int result = 0;
            if (model != null)
            {
                await Task.Run(() => { _context.Set<T>().Remove(model); });
                result = _context.SaveChanges();
            }

            return result;
        }

        public async Task<IEnumerable<T>> GetListAsync()
        {
            return await Task.Run(() => _context.Set<T>().ToList());
        }
        #endregion


    }
}
