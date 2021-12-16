using Live_e_commerce.Common;
using Live_e_commerce.CreateUpdateDto;
using Live_e_commerce.Dto;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Live_e_commerce.Iservice
{
    public interface IUserService:IApplicationService
    {
        /// <summary>
        /// 登陆接口
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<ReturnResult<int>> Login(UserDto user);
        /// <summary>
        /// 注册接口
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<ReturnResult<int>> AddUser(UserDto user);
    }
}
