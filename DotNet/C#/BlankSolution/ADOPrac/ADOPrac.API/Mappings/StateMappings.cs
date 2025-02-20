using ADOPrac.API.DTOs.StateDTOs;
using ADOPrac.BusinessLogicLayer.Models;

namespace ADOPrac.API.Mappings
{
    public static class StateMappings
    {
        public static void MapCreateStateDtoWithState(this State state , CreateStateDto createStateDto)
        {
            state.CountryId = createStateDto.CountryId;
            state.StateName = createStateDto.StateName;
            state.StateDescription = createStateDto.StateDescription;
        }

        public static void MapUpdateStateDtoWithState(this State state, UpdateStateDto updateStateDto)
        {
            state.StateId = updateStateDto.StateId;
            state.CountryId = updateStateDto.CountryId;
            state.StateName = updateStateDto.StateName;
            state.StateDescription = updateStateDto.StateDescription;
        }
    }
}
