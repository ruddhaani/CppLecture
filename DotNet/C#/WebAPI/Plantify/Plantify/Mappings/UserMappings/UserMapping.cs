using Plantify.Dtos.UserDtos;
using Plantify.Entity;

namespace Plantify.Mappings.UserMappings
{
    public static class UserMapping
    {
        public static void MapCreateUserDtoWithUser(this UserInformation user , CreateUserDto createUserDto)
        {
            user.Name = createUserDto.Name;
            user.Email = createUserDto.Email;
            user.PhoneNumber = createUserDto.PhoneNumber;
            user.Password = createUserDto.Password;

        }
    }
}
