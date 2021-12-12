using Live_e_commerce.Dto;
using Live_e_commerce.Entities;
using Live_e_commerce.Iservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Live_e_commerce.Service
{
    public class UserService : ApplicationService, IUserService
    {
        IRepository<User> _repository;
        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<UserDto> Query(UserDto user)
        {
            //ReturnResult result = new ReturnResult();
            if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.PassWord))
            {
                //result.States = States.Fail;
                //result.Data = null;
                //return result;
                return new UserDto { Msg = "账号或密码不能为空", State = false };
            }

            var a = await _repository.GetListAsync();
            ObjectMapper.Map<List<User>, List<UserDto>>(a);

            var u = a.Where(p => p.Name.Equals(user.Name) && p.PassWord.Equals(user.PassWord)).FirstOrDefault();
            if (u == null)
            {
                return new UserDto { Msg = "账号或密码错误", State = false };
            }
            else
            {
                return new UserDto { Msg = "登录成功", State = true, Name = u.Name };
            }

        }

     
       
    }


    //public class ReturnResult
    //{
    //    public States States { get; set; }

    //    public IEnumerable<UserDto> Data { get; set; }
    //}

}
