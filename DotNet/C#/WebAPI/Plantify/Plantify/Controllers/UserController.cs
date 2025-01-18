using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plantify.Dtos.UserDtos;
using Plantify.Entity;
using Plantify.Mappings.UserMappings;
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

        [HttpPut("password")]
        public async Task<ActionResult> UpdatePassword(UpdatePasswordDto updatePassword)
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
                var claimsPrincipal = _jwtService.ValidateToken(token);

                var id = claimsPrincipal.FindFirst("UserId")?.Value;

                if (string.IsNullOrEmpty(id))
                {
                    return Unauthorized();
                }

                var user = await _userService.UserDetails(Convert.ToInt32(id));

                if (!(string.IsNullOrEmpty(updatePassword.Password) || string.IsNullOrEmpty(Convert.ToString(updatePassword.OldPassword))))
                {
                    if (user.Password == updatePassword.OldPassword)
                    {
                        user.MapUpdatePasswordWithUser(updatePassword);

                        _userService.UpdateUser(user);

                        if (await _userService.SaveChangesToDbAsync())
                        {
                            return Ok();
                        }

                        return BadRequest();
                    }

                    return BadRequest();
                }


                return BadRequest();

            }catch(Exception ex)
            {
                return Unauthorized();
            }
        }

        [HttpGet("userDetails")]
        public async Task<ActionResult<UserResponse>> UserDetails()
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
                var claimsPrincipal = _jwtService.ValidateToken(token);

                var id = claimsPrincipal.FindFirst("UserId")?.Value;

                if (string.IsNullOrEmpty(id))
                {
                    return Unauthorized("Please log in or sign up!");
                }

                UserResponse userResponse = new UserResponse(await _userService.UserDetails(Convert.ToInt32(id)));

                return Ok(userResponse);
            }catch(Exception ex)
            {
                return Unauthorized("Please log in or sign up!");
            }
        }

        [HttpPut("updateUser")]
        public async Task<ActionResult> UpdateUser(UpdateUserDto updateUser)
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
                var claimsPrincipal = _jwtService.ValidateToken(token);

                var id = claimsPrincipal.FindFirst("UserId")?.Value;

                if (string.IsNullOrEmpty(id))
                {
                    return Unauthorized("Please log in or sign up");
                }

                var user = await _userService.UserDetails(Convert.ToInt32(id));

                if(!(string.IsNullOrEmpty(updateUser.Email) || string.IsNullOrEmpty(updateUser.Name) || string.IsNullOrEmpty(Convert.ToString(updateUser.PhoneNumber)))){
                    user.MapUpdateUserDtoWithUser(updateUser);

                    _userService.UpdateUser(user);

                    if (await _userService.SaveChangesToDbAsync())
                    {
                        return Ok(user);
                    }

                    return BadRequest();
                }

                return BadRequest();
                

            }catch(Exception ex)
            {
                return Unauthorized();
            }
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
