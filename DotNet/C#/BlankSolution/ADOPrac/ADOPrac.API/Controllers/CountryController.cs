using ADOPrac.API.DTOs.CountryDTOs;
using ADOPrac.API.Mappings;
using ADOPrac.BusinessLogicLayer.IRepository;
using ADOPrac.BusinessLogicLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADOPrac.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        [HttpGet("list")]
        public IActionResult GetCountryList()
        {
            var countriesList = _countryRepository.GetCountriesList();
            if (countriesList.Count > 0) return Ok(countriesList);
            else return BadRequest("No countries on this planet");
        }

        [HttpGet]
        public IActionResult GetCountryById([FromQuery] int id)
        {
            var country = _countryRepository.GetCountryById(id);
            if (country.CountryId > 0) return Ok(country);
            else return NotFound("Country not found on this planet");
        }

        [HttpPost("create")]
        public IActionResult Create(CreateCountryDto createCountryDto)
        {
            Country country = new Country();
            country.MapCreateCountryDtoWithCountry(createCountryDto);
            var result = _countryRepository.Create(country);
            return Ok(result);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _countryRepository.Delete(id);
            return Ok(result);
        }
    }
}
