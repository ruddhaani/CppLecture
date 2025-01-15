namespace Plantify.Dtos.UserDtos
{
    public class CreateUserDto
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public long PhoneNumber { get; set; }

        public string Password { get; set; }
    }
}
