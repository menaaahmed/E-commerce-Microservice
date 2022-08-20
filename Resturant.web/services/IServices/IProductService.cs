using Resturant.web.Models;

namespace Resturant.web.services.IServices
{
    public interface IProductService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductsByIdAsync<T>(int id);
        Task<T> CreateProductsAsync<T>(ProductDto ProductDto);
        Task<T> UpdateProductsAsync<T>(ProductDto ProductDto);
        Task<T> DeleteProductsAsync<T>(int id);
        

    }
}
