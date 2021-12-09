using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Live_e_commerce.Entities
{
    [Table("User")]
    /// <summary>
    /// 用户登录表
    /// </summary>
    public  class User: AuditedAggregateRoot<Guid>
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
