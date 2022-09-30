using AutoMapper;

namespace FirstNZWalks.API.Profiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>().ReverseMap();

           
        //        .ForMember(dest => dest.Id, options => options.MapFrom(src => src.Id))
        //        .ForMember(dest => dest.Area, options => options.MapFrom(src => src.Area))
        //        .ForMember(dest => dest.Code, options => options.MapFrom(src => src.Code)) 
        //        .ForMember(dest => dest.Lat, options => options.MapFrom(src => src.Lat))
        //        .ForMember(dest => dest.Long, options => options.MapFrom(src => src.Long))
        //        .ForMember(dest => dest.Population, options => options.MapFrom(src => src.Population));
        //
        }
    }
}
