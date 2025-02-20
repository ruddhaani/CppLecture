using System.Runtime.CompilerServices;
using ADOPrac.API.DTOs;
using ADOPrac.BusinessLogicLayer.Models;
using AutoMapper;

namespace ADOPrac.API.Mappings.Profiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<UpdateCompanyDto, Company>()
                .ForMember(dest => dest.CompanyId, opt => opt.Ignore());
        }
    }
}
