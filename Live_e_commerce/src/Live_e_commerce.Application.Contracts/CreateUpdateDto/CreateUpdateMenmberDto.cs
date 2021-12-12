using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Live_e_commerce.CreateUpdateDto
{
   public class CreateUpdateMenmberDto
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
