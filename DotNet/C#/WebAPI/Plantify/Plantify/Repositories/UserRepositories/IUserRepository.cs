using Plantify.Entity;

namespace Plantify.Repositories.UserRepositories
{
    public interface IUserRepository
    {
        public Task<UserInformation> GetUser(string email, string password);

        public UserInformation AddUser(UserInformation user);

        public Task<UserInformation> FindUser(string userId);

        public void DeleteUser(UserInformation user);

        public Task<bool> FindUserByEmail(string email);

        public Task<bool> SaveChangesToDbAsync();
    }
}
