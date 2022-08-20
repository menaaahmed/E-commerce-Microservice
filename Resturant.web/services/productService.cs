using Resturant.web.Models;
using Resturant.web.services.IServices;

namespace Resturant.web.services
{
    public class productService : IProductService
    {
        public Task<T> CreateProductsAsync<T>(ProductDto ProductDto)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteProductsAsync<T>(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAllProductsAsync<T>()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetProductsByIdAsync<T>(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateProductsAsync<T>(ProductDto ProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
