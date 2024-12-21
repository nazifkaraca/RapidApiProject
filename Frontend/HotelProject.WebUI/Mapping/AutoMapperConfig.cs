using AutoMapper;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.LoginDto;


namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Services>().ReverseMap();
            CreateMap<UpdateServiceDto, Services>().ReverseMap();
            CreateMap<CreateServiceDto, Services>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
        }
    }
}
