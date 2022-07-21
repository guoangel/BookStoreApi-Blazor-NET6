using AutoMapper;
using BookStoreApi.Blazor.Server.UI.Services.Base;

namespace BookStoreApi.Blazor.Server.UI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorReadOnlyDto, AuthorUpdateDto>().ReverseMap();
        }
    }
}
