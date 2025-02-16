using ADOPrac.API.DTOs;
using ADOPrac.API.Mappings;
using ADOPrac.BusinessLogicLayer.IRepository;
using ADOPrac.BusinessLogicLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADOPrac.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
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
                company.MapUpdateCompanyDTOWithCompany(updateCompanyDto);
                var result = _companyRepository.Update(company);
                return Ok(result);
            }

            return BadRequest("Not Updated");
            
        }

        [HttpGet]
        public IActionResult GetById([FromQuery] int id)
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
            return Ok(result);
        }

        [HttpDelete("delete/{id}")]

        public IActionResult Delete([FromRoute] int id)
        {
            var result = _companyRepository.Delete(id);
            return Ok(result);
        }

    }
}
