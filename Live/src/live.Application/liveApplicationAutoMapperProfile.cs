using AutoMapper;
using live.Dto;
using live.entity;

namespace live
{
    public class liveApplicationAutoMapperProfile : Profile
    {
        public liveApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Member, MemberDto>();
            CreateMap<CreateUpdateMemberDto, Member>();
        }
    }
}
