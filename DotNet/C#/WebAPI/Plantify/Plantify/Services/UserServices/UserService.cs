using Plantify.Dtos.UserDtos;
using Plantify.Entity;
using Plantify.Repositories.UserRepositories;

namespace Plantify.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<UserInformation> GetUser(string email, string password)
        {
            return await _userRepository.GetUser(email, password);
        }

        public UserInformation AddUser(CreateUserDto user)
        {
            UserInformation userInformation = new UserInformation(user);
            return _userRepository.AddUser(userInformation);
        }

        public async Task<bool> FindUserByEmail(string email)
        {
            return await _userRepository.FindUserByEmail(email);
        }

        public void DeleteUser(UserInformation user)
        {
            _userRepository.DeleteUser(user);
        }

        public async Task<bool> SaveChangesToDbAsync()
        {
            return await _userRepository.SaveChangesToDbAsync();
        }

        public async Task<UserInformation> FindUser(string userId)
        {
            return await _userRepository.FindUser(userId);
        }
    }
}
