namespace ElectronicsShop.DTOs.OrderDTOs
{
    public class AddOrderDto
    {
        public List<AddOrderItemDto> OrderItems { get; set; }
    }

    public class AddOrderItemDto
    {
        public int ProductId { get; set; }
    }

    public class UpdateOrderItemDto
    {
        public int ProductId { get; set; }
    }

    public class OrderResponseDto
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public List<OrderItemResponseDto> OrderItems { get; set; }
    }

    public class OrderItemResponseDto
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } 
    }
}
