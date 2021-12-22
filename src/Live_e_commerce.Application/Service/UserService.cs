using Live_e_commerce.Common;
using Live_e_commerce.Dto;
using Live_e_commerce.Entities;
using Live_e_commerce.Iservice;
using Live_e_commerce.SafetyVerification;
using LiveApp.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
        #region
        private IRepository<User> _repository;
        private IConfiguration _configuration;
        public UserService(IRepository<User> repository, IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }
        #endregion

        #region 注册实现
        /// <summary>
        /// 注册实现
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost,Route("AddUser")]
        public async Task<ReturnResult<int>> AddUser(UserDto user)
        {
            var name = _repository.FirstOrDefault(x => x.Name == user.Name);
            if (name != null)
            {
                return new ReturnResult<int> { Msg="用户名已存在",State=500};
            }
            user.PassWord = StringHelper.MD5Hash(user.PassWord);
            var data = ObjectMapper.Map<UserDto, User>(user);
            await _repository.InsertAsync(data);
            return new ReturnResult<int> { Msg = "添加成功" ,State=200};
        }
        #endregion
        #region 登陆实现
        /// <summary>
        /// 登陆实现
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost,Route("Login")]
        public async Task<ReturnResult<int>> Login(UserDto user)
        {
            Ids4Service ids = new Ids4Service(_configuration);

            if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.PassWord))
            {
                return new ReturnResult<int> {
                    Msg = "账号或密码不能为空", 
                    State =Convert.ToInt32(CommonEnum.LoginStates.UsersNotexist)
                };
            }

            var data = await _repository.GetListAsync();
            var token = Live_e_commerce.JWT.JwtToken.CreateToken(user.Name);
            ObjectMapper.Map<List<User>, List<UserDto>>(data);
            var u = data.Where(p => p.Name.Equals(user.Name) && p.PassWord.Equals(StringHelper.MD5Hash(user.PassWord))).FirstOrDefault();       
            if (u == null)
            {
                return new ReturnResult<int> {
                    Msg = "账号或密码错误",
                    State = Convert.ToInt32(CommonEnum.LoginStates.WrongPassword)
                };
            }
            else
            {
                return new ReturnResult<int> {
                    Msg = "登录成功", 
                    State=Convert.ToInt32( CommonEnum.LoginStates.SuccessFully),
                    Date= u.Name,
                    Token =token
                };
            }

        }
        #endregion

    }
}
