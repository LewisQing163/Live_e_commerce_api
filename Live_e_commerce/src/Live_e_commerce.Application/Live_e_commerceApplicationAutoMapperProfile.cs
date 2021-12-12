using AutoMapper;
using Live_e_commerce.CreateUpdateDto;
using Live_e_commerce.Dto;
using Live_e_commerce.Entities;


namespace Live_e_commerce
{
    public class Live_e_commerceApplicationAutoMapperProfile : Profile
    {
        public Live_e_commerceApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Member, MemberDto>();
            CreateMap<CreateUpdateMenmberDto, Member>();
            CreateMap<User, UserDto>();
        }
    }
}
