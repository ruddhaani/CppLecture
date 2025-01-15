using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Plantify.Dtos.UserDtos;

namespace Plantify.Entity
{
    public class UserInformation
    {

        public UserInformation()
        {

        }

        public UserInformation(CreateUserDto createUserDto)
        {
            Name = createUserDto.Name;
            Email = createUserDto.Email;
            PhoneNumber = createUserDto.PhoneNumber;
            Password = createUserDto.Password;

        }

        [Key]
        public int userId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public long PhoneNumber { get; set; }

        public string Password { get; set; }
    }
}
