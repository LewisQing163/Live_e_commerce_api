using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

#nullable disable

namespace Live_e_commerce.Dto
{
    /// <summary>
    /// 会员表
    /// </summary>
    public partial class MemberDto:AuditedEntityDto<Guid>
    {
        /// 会员类型
        /// </summary>
        public string MemberName { get; set; }
        /// <summary>
        /// 用户基础表id
        /// </summary>
        public Guid Uid { get; set; }
    }
}
