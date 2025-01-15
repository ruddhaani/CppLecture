using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plantify.Dtos.UserDtos;
using Plantify.Entity;
using Plantify.Responses.UserResponses;
using Plantify.Services.JWT;
using Plantify.Services.UserServices;

namespace Plantify.Controllers
{
    public class UserController : BaseAPIController
    {
        private readonly JwtService _jwtService;
        private readonly IUserService _userService;

        public UserController(IUserService userService , JwtService jwtService)
        {
            _userService = userService;
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login([FromBody] LoginDto loginDto)
        {
            var user = await _userService.GetUser(loginDto.Email, loginDto.Password);
            Console.WriteLine(loginDto.Password);

            if (user == null)
            {
                return Unauthorized("Invalid email or password.");
            }

            var token = _jwtService.GenerateToken(user);
            return Ok(token);
        }

        [Authorize]
        [HttpGet("me")]
        public async Task<ActionResult<UserResponse>> GetMyDetails()
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
                var claimsPrincipal = _jwtService.ValidateToken(token);

                var id = claimsPrincipal.FindFirst("UserId")?.Value;
                Console.WriteLine(id);


                if (string.IsNullOrEmpty(id))
                {
                    return Unauthorized("Invalid token.");
                }

                var user = await _userService.FindUser(id);

                if (user == null)
                {
                    return NotFound("User not found.");
                }

                return Ok(new UserResponse(user));
            }
            catch (Exception ex)
            {
                return Unauthorized($"Token validation failed: {ex.Message}");
            }
        }

        [HttpGet("validate")]
        public async Task<ActionResult<bool>> IsTokenValid()
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

                bool isValid = _jwtService.ValidateTokenForRemoval(token);

                if (isValid)
                {
                    return Ok();
                }

                return BadRequest();
            }
            catch(Exception ex)
            {
                return Unauthorized($"Token validation failed: {ex.Message}");
            }
        }


        [HttpGet]
        public async Task<ActionResult<UserResponse>> GetUser(string email, string password)
        {

            UserInformation user = await _userService.GetUser(email, password);

            if (user != null)
            {
                return Ok(new UserResponse(user));
            }

            return NotFound("User Not Found");

        }

        [HttpPost]
        public async Task<ActionResult<UserResponse>> AddUser([FromBody] CreateUserDto createUserDto)
        {

            if(await _userService.FindUserByEmail(createUserDto.Email))
            {
                return BadRequest("User with this email already exists!");
            }

            UserInformation user = _userService.AddUser(createUserDto);

            if(await _userService.SaveChangesToDbAsync())
            {
                return Ok(new UserResponse(user));
            }

            return BadRequest("User Not Created");
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteUser(string email , string password)
        {
            UserInformation user = await _userService.GetUser(email, password);

            if (user != null)
            {
                _userService.DeleteUser(user);

                if (await _userService.SaveChangesToDbAsync())
                {
                    return Ok($"User deleted");
                }

                return BadRequest("User not deleted");
            }

            return NotFound("User not found");

            
        }
    }
}
