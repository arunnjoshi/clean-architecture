using AutoMapper;
using Clean.Domain;

namespace Clean.Application.Demo.Queries
{
    partial class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DemoEntity, GetDemoResponse>().ReverseMap();
        }
    }
}
