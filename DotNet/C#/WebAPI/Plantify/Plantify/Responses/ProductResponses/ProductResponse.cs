using Plantify.Entity;

namespace Plantify.Responses.ProductResponses
{
    public class ProductResponse
    {
        public ProductResponse()
        {

        }

        public ProductResponse(Product product)
        {
            ProductId = product.ProductId;
            ProductName = product.ProductName;
            ProductDescription = product.ProductDescription;
            ProductType = product.ProductType;
            Price = product.Price;
            ProductImageUrl = product.ProductImageUrl;

        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ProductType { get; set; }

        public string Price { get; set; }

        public string ProductImageUrl { get; set; }
    }
}
