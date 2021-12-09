using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace live.Dto
{
   public class MemberDto:AuditedEntityDto<Guid>
    {
        public string MemberName { get; set; }
        public Guid Uid { get; set; }
    }
}
