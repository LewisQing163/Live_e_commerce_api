using AutoMapper;
using Live_Commerce.Dto;
using Live_Commerce.Entities;

namespace Live_Commerce
{
    public class Live_CommerceApplicationAutoMapperProfile : Profile
    {
        public Live_CommerceApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Member, MemberDto> ();
            CreateMap<CreateUpdateDto, Member>();


        }
    }
}
