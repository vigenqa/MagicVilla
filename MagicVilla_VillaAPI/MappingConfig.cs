using AutoMapper;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDto>();
            CreateMap<VillaDto, Villa>();

            CreateMap<VillaCreateDto, Villa>(); // Add this mapping
            CreateMap<VillaUpdateDto, Villa>(); // Add this mapping
            CreateMap<VillaDto, VillaCreateDto>().ReverseMap();
            CreateMap<VillaDto, VillaUpdateDto>().ReverseMap();


            CreateMap<VillaNumber, VillaNumberDto>();
            CreateMap<VillaNumberDto, VillaNumber>();

            CreateMap<VillaNumberCreateDTO, VillaNumber>(); // Add this mapping
            CreateMap<VillaNumberUpdateDto, VillaNumber>(); // Add this mapping
            CreateMap<VillaNumberDto, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumberDto, VillaNumberUpdateDto>().ReverseMap();
        }
    }
}
