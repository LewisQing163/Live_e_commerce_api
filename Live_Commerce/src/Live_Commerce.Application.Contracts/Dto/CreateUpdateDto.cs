using System;
using System.Collections.Generic;
using System.Text;

namespace Live_Commerce.Dto
{
    public class CreateUpdateDto
    {
        /// <summary>
        /// 会员类型
        /// </summary>
        public string MemberName { get; set; }
        /// <summary>
        /// 用户基础表id
        /// </summary>
        public Guid Uid { get; set; }
    }
}
