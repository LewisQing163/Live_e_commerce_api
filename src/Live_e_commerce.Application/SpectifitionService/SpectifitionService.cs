using Live_e_commerce.CreateUpdateDto;
using Live_e_commerce.Dto;
using Live_e_commerce.Entities;
using Live_e_commerce.ISpecification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Live_e_commerce.SpectifitionService
{
    public class SpectifitionService : CrudAppService<Specification, SpecificationDto, Guid, PagedAndSortedResultRequestDto,CreateUpdateSpecifitionDto>, ISpecificationService
    {
        public SpectifitionService(IRepository<Specification, Guid> repository) : base(repository)
        { 
        }
    }
}
