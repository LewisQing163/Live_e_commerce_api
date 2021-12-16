using System;
using System.Collections.Generic;
using System.Text;


namespace Live_e_commerce.Common
{
    public class ReturnResult<T>
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 消息提示
        /// </summary>

        public string Msg { get; set; }
        /// <summary>
        /// 数据
        /// </summary>

        public string Date { get; set; }
        /// <summary>
        /// token
        /// </summary>
        public string Token { get; set; }
    }
}
