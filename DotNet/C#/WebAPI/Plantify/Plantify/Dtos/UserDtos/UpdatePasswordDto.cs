using System.Diagnostics.CodeAnalysis;

namespace Plantify.Dtos.UserDtos
{
    public class UpdatePasswordDto
    {
        [NotNull]
        public string Password { get; set; }

        [NotNull]
        public string OldPassword { get; set; }
    }
}
