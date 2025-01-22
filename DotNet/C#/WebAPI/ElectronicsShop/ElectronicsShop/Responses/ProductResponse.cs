using ElectronicsShop.Entities;

namespace ElectronicsShop.Responses
{
    public class ProductResponse
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public long ProductStockQuantity { get; set; }
        public int ProductCategoryId { get; set; }
        public string Category { get; set; }

        public List<string> ProductImageUrls { get; set; }
    }
}
