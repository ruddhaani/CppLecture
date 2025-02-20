using ADOPrac.API.DTOs.CountryDTOs;
using ADOPrac.API.Mappings;
using ADOPrac.API.Response.CountryResponse;
using ADOPrac.BusinessLogicLayer.IRepository;
using ADOPrac.BusinessLogicLayer.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADOPrac.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;

        private readonly IMapper _mapper;
        public CountryController(ICountryRepository countryRepository , IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }
        [HttpGet("list")]
        public IActionResult GetCountryList()
        {
            var countriesList = _countryRepository.GetCountriesList();
            if (countriesList.Count > 0) return Ok(countriesList);
            else return BadRequest("No countries on this planet");
        }

        [HttpGet("getById/{id}")]
        public IActionResult GetCountryById(int id)
        {
            var country = _countryRepository.GetCountryById(id);
            if (country.CountryId > 0) return Ok(country);
            else return NotFound("Country not found on this planet");
        }

        [HttpPost("create")]
        public IActionResult Create(CreateCountryDto createCountryDto)
        {
            Country country = _mapper.Map<Country>(createCountryDto);
            var result = _countryRepository.Create(country);
            if (result == -1) return Ok("Created Successfully");
            else return BadRequest("Not created");
        }

        [HttpPut("delete/{id}")]
        public IActionResult Delete(int id , int flag)
        {
            var result = _countryRepository.ChangeIsActive(id , flag);
            if (result == -1) return Ok("Deleted Successfully");
            else return BadRequest("Not deleted");
        }

        
        [HttpPut("update")]
        public IActionResult Update([FromBody] UpdateCountryDto updateCountryDto)
        {
            var country = _countryRepository.GetCountryById(updateCountryDto.CountryId);

            if(country == null || country.CountryId == 0)
            {
                return BadRequest("Not updated");
            }

            _mapper.Map(updateCountryDto, country);

            var result = _countryRepository.Update(country);

            if (result == -1) return Ok("Updated Successfully");
            else return BadRequest("Not updated");
        }

        [HttpGet("dropdown")]
        public  IActionResult CountryDropdown()
        {
            var countries = _countryRepository.GetCountriesList();

            var countryDropdownResponses = countries.Select(country =>
            {
                var response = new CountryDropdownResponse();
                response.MapCountryDropdownResponseWithCountry(country);
                return response;
            }).ToList();

            return Ok(countryDropdownResponses);
        }
    }
}
