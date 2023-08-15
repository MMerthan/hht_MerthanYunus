using AutoMapper;
using MakineEntity.DTOs.Assets;
using MakineEntity.Entities;

namespace MakineBusiness.AutoMapper.Assets
{
    public class AssetProfile : Profile
    {
        public AssetProfile()
        {
            CreateMap<Asset, AssetAddDto>().ReverseMap();
            CreateMap<Asset, AssetDto>().ReverseMap();
        }
       
    }
}
