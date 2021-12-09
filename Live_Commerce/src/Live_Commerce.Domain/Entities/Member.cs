using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Live_Commerce.Entities
{
    [Table("Member")]
    /// <summary>
    /// 会员表
    /// </summary>
    public  class Member: AuditedAggregateRoot<Guid>
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
