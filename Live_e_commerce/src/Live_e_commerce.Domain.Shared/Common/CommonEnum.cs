using System;
using System.Collections.Generic;
using System.Text;

namespace Live_e_commerce.Common
{
    public class CommonEnum
    {
        public enum LoginStates
        {
            UsersNotexist = 1,//用户不存在
            SuccessFully = 2,//登录成功
            WrongPassword = 3 //密码错误
        }
    }
}
