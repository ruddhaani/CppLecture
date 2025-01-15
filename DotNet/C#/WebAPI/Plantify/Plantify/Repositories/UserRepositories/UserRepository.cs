using Microsoft.EntityFrameworkCore;
using Plantify.Data;
using Plantify.Entity;

namespace Plantify.Repositories.UserRepositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dbContext;

        public UserRepository(DataContext dbContext) {
            _dbContext = dbContext;
        }
        public UserInformation AddUser(UserInformation user)
        {
            _dbContext.Users.Add(user);
            return user;
        }

        public void DeleteUser(UserInformation user)
        {
            _dbContext.Users.Remove(user);
            Console.WriteLine("User Deleted");
        }

        public async Task<UserInformation> FindUser(string userId)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.userId == Convert.ToInt32(userId));
        }

        public async Task<bool> FindUserByEmail(string email)
        {
            UserInformation user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Email == email);

            if(user != null)
            {
                return true;
            }

            return false;
        }

        public async Task<UserInformation> GetUser(string email, string password)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => (x.Email == email && x.Password == password));
        }

        public async Task<bool> SaveChangesToDbAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
