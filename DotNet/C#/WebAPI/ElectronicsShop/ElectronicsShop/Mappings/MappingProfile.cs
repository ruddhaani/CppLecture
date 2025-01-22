using AutoMapper;
using ElectronicsShop.DTOs;
using ElectronicsShop.DTOs.CartDTOs;
using ElectronicsShop.DTOs.CategoryDTOs;
using ElectronicsShop.DTOs.OrderDTOs;
using ElectronicsShop.DTOs.ProductDTOs;
using ElectronicsShop.DTOs.ProductImageDTOs;
using ElectronicsShop.DTOs.UserDTOs;
using ElectronicsShop.Entities;
using ElectronicsShop.Responses;

namespace ElectronicsShop.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // User mapping
            CreateMap<CreateUserDto, User>();
            CreateMap<User, UserResponse>();
            CreateMap<UpdateUserDto, User>();
            CreateMap<AddCategoryDto, ProductCategory>();
            CreateMap<AddProductDto, Product>();
            CreateMap<Product, ProductResponse>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.ProductCategory.Category))
                .ForMember(dest => dest.ProductImageUrls , opt => opt.MapFrom(src => src.ProductImages.Select(img => img.Url).ToList()));

            CreateMap<UpdateProductDto, Product>();

            CreateMap<AddProductImageDto, ProductImage>();

            CreateMap<UpdateProductImageDto, ProductImage>();

            CreateMap<AddCartItemDto, CartItem>();

            CreateMap<Cart, CartResponse>();

            CreateMap<CartItem, CartItemResponse>()
                    .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName));

            CreateMap<AddOrderDto, Order>();
            CreateMap<AddOrderItemDto, OrderItem>();
            CreateMap<Order, OrderResponseDto>();
            CreateMap<OrderItem, OrderItemResponseDto>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName));
        }
    }
}
