using ADOPrac.API.DTOs.CountryDTOs;
using ADOPrac.BusinessLogicLayer.Models;

namespace ADOPrac.API.Mappings
{
    public static class CountryMappings
    {
        public static void MapCreateCountryDtoWithCountry(this Country country , CreateCountryDto countryDto)
        {
            country.CountryName = countryDto.CountryName;
            country.CountryDescription = countryDto.CountryDescription;
        }

        public static void MapUpdateCountryDtoWithCountry(this Country country, UpdateCountryDto countryDto)
        {
            country.CountryName = countryDto.CountryName;
            country.CountryDescription = countryDto.CountryDescription;
        }
    }
}
