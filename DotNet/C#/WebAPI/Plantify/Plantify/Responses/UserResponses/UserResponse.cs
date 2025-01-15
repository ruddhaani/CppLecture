using Plantify.Entity;

namespace Plantify.Responses.UserResponses
{
    public class UserResponse
    {
        public UserResponse()
        {

        }

        public UserResponse(UserInformation user)
        {
            userId = user.userId;
            Name = user.Name;
            Email = user.Email;
            PhoneNumber = user.PhoneNumber;
        }
        public int userId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public long PhoneNumber { get; set; }

    }
}
