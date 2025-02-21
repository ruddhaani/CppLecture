using System.Security.Cryptography.Xml;
using ADOPrac.API.DTOs.StateDTOs;
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
    public class StateController : ControllerBase
    {
        private readonly IStateRepository _stateRepository;

        private readonly IMapper _mapper;

        public StateController(IStateRepository stateRepository , IMapper mapper)
        {
            _stateRepository = stateRepository;
            _mapper = mapper;
        } 

        [HttpGet("list")]
        public IActionResult GetStateList()
        {
            var states = _stateRepository.GetStatesList();

            return Ok(states); 
        }

        [HttpGet("getById/{id}")]
        public IActionResult GetStateById(int id)
        {
            var state = _stateRepository.GetStateById(id);
            return Ok(state);
        }

        [HttpPost("create")]
        public IActionResult CreateState(CreateStateDto createStateDto)
        {
            State state = _mapper.Map<State>(createStateDto);

            var result = _stateRepository.Create(state);

            if (result == -1) return Ok("State Created Successfully");
            else return BadRequest("State not created");
        }

        [HttpPut("update")]
        public IActionResult UpdateState(UpdateStateDto updateStateDto)
        {
            State state = _mapper.Map<State>(updateStateDto);

            var result = _stateRepository.Update(state);

            if (result == -1) return Ok("Updated Successfully");
            else return BadRequest("Not updated");
        }
    }
}
