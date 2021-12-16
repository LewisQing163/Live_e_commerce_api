using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

#nullable disable

namespace Live_e_commerce.Entities
{
    [Table("UserBase")]
    /// <summary>
    /// 用户基础表
    /// </summary>
    public  class UserBase: AuditedAggregateRoot<Guid>
    {

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int? Age { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int? Sex { get; set; }
        /// <summary>
        /// 爱好
        /// </summary>
        public string Hobby { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string NikeName { get; set; }
        /// <summary>
        /// 个人签名
        /// </summary>
        public string Sign { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? Birthday { get; set; }
    }
}
