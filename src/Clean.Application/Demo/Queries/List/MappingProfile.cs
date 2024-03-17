using AutoMapper;
using Clean.Domain;

namespace Clean.Application.Demo.Queries.List
{
    partial class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DemoEntity, GetDemoResponse>().ReverseMap();
        }
    }
}
