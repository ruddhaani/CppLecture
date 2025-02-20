using ADOPrac.API.DTOs;
using ADOPrac.API.Mappings;
using ADOPrac.BusinessLogicLayer.IRepository;
using ADOPrac.BusinessLogicLayer.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADOPrac.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CompanyController(ICompanyRepository companyRepository , IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        [HttpGet("list")]

        public IActionResult GetList()
        {
            var companies = _companyRepository.ListAllCompanies();
            if(companies != null && companies.Count > 0)
            {
                return Ok(companies);
            }

            return BadRequest("No data to be shown");
        }

        [HttpPut("update/{id}")]
        public IActionResult Update([FromRoute]int id, [FromBody] UpdateCompanyDto updateCompanyDto)
        {
            Company company = _companyRepository.GetCompanyById(id);
            
            if(company != null || company.CompanyId != 0)
            {
                _mapper.Map(updateCompanyDto, company);
                var result = _companyRepository.Update(company);
                if (result == -1) return Ok("Updated Successfully");
                else return BadRequest("Not updated");
            }

            return BadRequest("Not Updated");
            
        }

        [HttpGet("getById/{id}")]
        public IActionResult GetById(int id)
        { 
            var company = _companyRepository.GetCompanyById(id);
            if(company == null || company.CompanyId == 0)
            {
                return BadRequest("No data to be shown");
            }
            return Ok(company);
        }

        [HttpPost("create")]

        public IActionResult Create([FromBody] Company company)
        {
            var result = _companyRepository.Create(company);
            if (result == -1) return Ok("Created Successfully");
            else return BadRequest("Not Created");
        }

        [HttpDelete("delete/{id}")]

        public IActionResult Delete([FromRoute] int id)
        {
            var result = _companyRepository.Delete(id);
            if (result == -1) return Ok("Deleted Successfully");
            else return BadRequest("Not deleted");
        }

    }
}
