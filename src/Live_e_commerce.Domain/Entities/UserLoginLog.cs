using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Live_e_commerce.Entities
{
    [Table("UserLoginLog")]
    /// <summary>
    /// 用户登录日志表
    /// </summary>
    public  class UserLoginLog : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 操作类型:成功或者失败
        /// </summary>
        public int? Command { get; set; }
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 登录id
        /// </summary>
        public Guid? Lid { get; set; }

    }
}
