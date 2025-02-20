using ADOPrac.API.DTOs.StateDTOs;
using ADOPrac.BusinessLogicLayer.Models;
using AutoMapper;

namespace ADOPrac.API.Mappings.Profiles
{
    public class StateProfile : Profile
    {
        public StateProfile()
        {
            CreateMap<CreateStateDto, State>();
            CreateMap<UpdateStateDto, State>();
        }
    }
}
