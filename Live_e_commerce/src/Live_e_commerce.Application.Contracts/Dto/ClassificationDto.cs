using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Live_e_commerce.Dto
{
    public class ClassificationDto : AuditedEntityDto<Guid>
    {
        /// <summary>
        /// 类别
        /// </summary>
        public string Name { get; set; }
    }
}
