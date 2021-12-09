using Live_Commerce.Dto;
using Live_Commerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Live_Commerce.Service
{
    public class MemberService:CrudAppService<Member,MemberDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateDto>
    {
        public MemberService(IRepository<Member,Guid> repository):base(repository)
        {
        }
    }
}
