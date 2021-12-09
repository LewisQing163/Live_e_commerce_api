using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Live_e_commerce.Entities
{
    [Table("UserExtra")]
    /// <summary>
    /// 用户扩展表
    /// </summary>
    public  class UserExtra : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 用户基础表id
        /// </summary>
        public Guid? Uid { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 扩展字段1
        /// </summary>
        public string Extend1 { get; set; }
        /// <summary>
        /// 扩展字段2
        /// </summary>
        public string Extend2 { get; set; }
    }
}
