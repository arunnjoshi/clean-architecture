using AutoMapper;
using Clean.Domain.Entitles;

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
