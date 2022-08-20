using resturant.productApi.Models;

namespace resturant.productApi.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductsById(int ProductId);
        Task<ProductDto> CreateProducts(ProductDto ProductDto);
        Task<ProductDto> UpdateProducts(ProductDto ProductDto);
        Task<bool> DeleteProducts(int ProductId);

    }
}
