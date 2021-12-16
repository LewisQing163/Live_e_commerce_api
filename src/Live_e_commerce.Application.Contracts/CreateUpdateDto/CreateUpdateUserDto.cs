using System;
using System.Collections.Generic;
using System.Text;

namespace Live_e_commerce.CreateUpdateDto
{
    public class CreateUpdateUserDto
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }
    }
}
