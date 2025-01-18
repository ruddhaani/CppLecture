using System.Diagnostics.CodeAnalysis;

namespace Plantify.Dtos.UserDtos
{
    public class UpdateUserDto
    {

        [NotNull]
        public string Name { get; set; }

        [NotNull]
        public string Email { get; set; }

        [NotNull]
        public long PhoneNumber { get; set; }

    }
}
