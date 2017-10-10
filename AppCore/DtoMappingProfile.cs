using AppCore.Models;
using AutoMapper;
using Infrastructure.Models;

namespace AppCore
{
    class DtoMappingProfile : Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
