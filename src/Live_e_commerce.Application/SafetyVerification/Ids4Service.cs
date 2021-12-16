using IdentityModel.Client;
using Live_e_commerce.Dto;
using Live_e_commerce.ISafetyVerification;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Live_e_commerce.SafetyVerification
{
    public class Ids4Service : ApplicationService,IIds4Service
    {

        private IConfiguration _configuration;
        public Ids4Service(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet,Route("GetIdsTokenAsync")]
        public async Task<string> GetIdsTokenAsync(UserDto UserDto)
        {
            var client = new HttpClient();
            //ids4访问url地址
            var idsTokenUrl = this._configuration.GetSection("AuthServer:Authority").Value;
            //访问id
            var AppClientId = this._configuration.GetSection("AuthServer:AppClientId").Value;
            //访问密码
            var AppClientSecret = this._configuration.GetSection("AuthServer:AppClientSecret").Value;
            var disco = client.GetDiscoveryDocumentAsync(idsTokenUrl);
            var tokenResponse = await client.RequestPasswordTokenAsync(
                new PasswordTokenRequest
                {
                    Address = disco.Result.TokenEndpoint,
                    ClientId=AppClientId,
                    ClientSecret=AppClientSecret,
                    UserName=UserDto.Name,
                    Password=UserDto.PassWord                    
                }) ;
            if (tokenResponse.IsError)
            {
                return string.Empty;
            }
            return tokenResponse.AccessToken;
        }
    }
}
