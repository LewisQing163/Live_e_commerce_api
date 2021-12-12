﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Live_Commerce.Dto
{
    /// <summary>
    /// 会员表
    /// </summary>
    public class MemberDto : AuditedEntityDto<Guid>
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