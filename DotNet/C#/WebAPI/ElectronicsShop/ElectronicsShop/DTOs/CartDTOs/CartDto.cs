namespace ElectronicsShop.DTOs.CartDTOs
{
    public class CartResponse
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public List<CartItemResponse> CartItems { get; set; }
    }

    public class CartItemResponse
    {
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
