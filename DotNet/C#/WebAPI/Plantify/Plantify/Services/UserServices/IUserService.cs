using Plantify.Dtos.UserDtos;
using Plantify.Entity;

namespace Plantify.Services.UserServices
{
    public interface IUserService
    {
        public Task<UserInformation> GetUser(string email, string password);

        public UserInformation AddUser(CreateUserDto user);

        public void DeleteUser(UserInformation user);

        public Task<bool> FindUserByEmail(string email);

        public Task<UserInformation> FindUser(string userId);

        public Task<bool> SaveChangesToDbAsync();

        public void UpdateUser(UserInformation user);
        public Task<UserInformation> UserDetails(int userId);
    }
}
