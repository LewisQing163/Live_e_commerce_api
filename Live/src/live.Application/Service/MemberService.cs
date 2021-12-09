using live.Dto;
using live.entity;
using live.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace live.Service
{
    public class MemberService:CrudAppService<Member,MemberDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateMemberDto>,IMemberService
    {
        public MemberService(IRepository<Member,Guid> repository):base(repository)
        {

        }
    }
}
