using ProductUserRelationship.Entity;

namespace ProductUserRelationship.DTOs
{
    public record struct AddToCartDto(int UserId , int ProductId);
    
}
