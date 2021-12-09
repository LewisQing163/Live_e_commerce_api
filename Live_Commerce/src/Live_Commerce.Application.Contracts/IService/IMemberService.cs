﻿using Live_Commerce.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Live_Commerce.IService
{
    public interface IMemberService:ICrudAppService<MemberDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateDto>
    {
    }
}
