using ADOPrac.API.DTOs.CountryDTOs;
using ADOPrac.BusinessLogicLayer.Models;
using AutoMapper;

namespace ADOPrac.API.Mappings.Profiles
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<CreateCountryDto, Country>();
            CreateMap<UpdateCountryDto, Country>();
        }
    }
}
