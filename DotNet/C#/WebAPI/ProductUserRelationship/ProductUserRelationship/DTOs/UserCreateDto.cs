namespace ProductUserRelationship.DTOs
{
    public record struct UserCreateDto(string Name, string Email, double Phone , string Password);
}
