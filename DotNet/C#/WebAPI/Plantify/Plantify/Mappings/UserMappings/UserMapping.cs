using Plantify.Dtos.UserDtos;
using Plantify.Entity;

namespace Plantify.Mappings.UserMappings
{
    public static class UserMapping
    {
        public static void MapUpdateUserDtoWithUser(this UserInformation user , UpdateUserDto updateUserDto)
        {
            user.Name = updateUserDto.Name;
            user.Email = updateUserDto.Email;
            user.PhoneNumber = updateUserDto.PhoneNumber;
        }

        public static void MapUpdatePasswordWithUser(this UserInformation user , UpdatePasswordDto updatePassword)
        {
            user.Password = updatePassword.Password;
        }
    }
}
