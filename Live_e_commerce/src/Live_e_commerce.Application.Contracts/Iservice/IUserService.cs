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
        Task<UserDto> Query(UserDto user);
    }
}
