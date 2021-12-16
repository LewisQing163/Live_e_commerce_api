


using Live_e_commerce.CreateUpdateDto;
using Live_e_commerce.Dto;
using Live_e_commerce.Entities;
using Live_e_commerce.Iservice;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Live_e_commerce.Service
{
    public class MenmberAppService:CrudAppService<Member,MemberDto, Guid, PagedAndSortedResultRequestDto,CreateUpdateMenmberDto>, IMemberAppService
    {
        public MenmberAppService(IRepository<Member,Guid> repository) : base(repository)
        {

        }
    }
}
