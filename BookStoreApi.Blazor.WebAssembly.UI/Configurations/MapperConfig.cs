using AutoMapper;
using BookStoreApi.Blazor.WebAssembly.UI.Services.Base;

namespace BookStoreApi.Blazor.WebAssembly.UI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorReadOnlyDto, AuthorUpdateDto>().ReverseMap();
            CreateMap<BookDetailsDto, BookUpdateDto>().ReverseMap();
        }
    }
}
