using AutoMapper;
using ElectronicsShop.Data;
using ElectronicsShop.DTOs.UserDTOs;
using ElectronicsShop.Entities;
using ElectronicsShop.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace ElectronicsShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UserController(DataContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<UserResponse>> Register(CreateUserDto createUserDto)
        {
            var user = _mapper.Map<User>(createUserDto);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            var userResponse = _mapper.Map<UserResponse>(user);
            return Ok(userResponse);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<UserResponse>> Login(string Email, string Password)
        {
            var user = _context.Users.FirstOrDefault(x => ((x.Email == Email) && (x.Password == Password)));

            if(user == null)
            {
                return Unauthorized();
            }

            var userResponse = _mapper.Map<UserResponse>(user);

            return Ok(userResponse);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserResponse>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if(user == null)
            {
                return NotFound();
            }

            var userResponse = _mapper.Map<UserResponse>(user);

            return Ok(userResponse);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id , UpdateUserDto updateUserDto)
        {
            if(id <= 0)
            {
                return BadRequest();
            }

            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            _mapper.Map(updateUserDto, user);

            _context.Entry(user).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if(user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);

            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
