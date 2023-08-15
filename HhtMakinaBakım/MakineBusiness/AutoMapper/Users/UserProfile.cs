using AutoMapper;
using MakineEntity.DTOs.Assets;
using MakineEntity.DTOs.Users;
using MakineEntity.Entities;

namespace MakineBussines.AutoMapper.Users
{
	public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<AppUser, UserDto>().ReverseMap();
            CreateMap<AppUser, UserAddDto>().ReverseMap();
            CreateMap<AppUser, UserUpdateDto>().ReverseMap();
            CreateMap<AppUser, UserProfileDto>().ReverseMap();
           
            

        }
    }
}
