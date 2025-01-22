namespace ElectronicsShop.DTOs.ProductDTOs
{
    public class UpdateProductDto
    {
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public double ProductPrice { get; set; }

        public long ProductStockQuantity { get; set; }

        public int ProductCategoryId { get; set; }
    }
}
