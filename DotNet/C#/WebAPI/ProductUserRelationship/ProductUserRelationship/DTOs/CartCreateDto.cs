using ProductUserRelationship.Entity;

namespace ProductUserRelationship.DTOs
{
    public record struct CartCreateDto(List<Products> Products);
}
