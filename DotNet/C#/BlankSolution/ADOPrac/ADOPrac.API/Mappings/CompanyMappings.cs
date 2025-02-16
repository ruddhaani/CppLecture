using ADOPrac.API.DTOs;
using ADOPrac.BusinessLogicLayer.Models;

namespace ADOPrac.API.Mappings
{
    public static class CompanyMappings
    {
        public static void MapUpdateCompanyDTOWithCompany(this Company company , UpdateCompanyDto updateCompanyDto)
        {
            company.CompanyName = updateCompanyDto.CompanyName;
            company.CompanyAddress = updateCompanyDto.CompanyAddress;
        }
    }
}
