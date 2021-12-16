using Live_e_commerce.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Live_e_commerce.ISafetyVerification
{
    public interface IIds4Service
    {
        public Task<string> GetIdsTokenAsync(UserDto UserDto);
    }
}
