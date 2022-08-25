using Resturant.web.Models;
using Resturant.web.services.IServices;

namespace Resturant.web.services
{
    public class productService : BaseService , IProductService
    {
        private readonly IHttpClientFactory _ClientFactory;

        public productService(IHttpClientFactory ClientFactory) : base(ClientFactory)
        {
            _ClientFactory = ClientFactory;

        }

        public async Task<T> CreateProductsAsync<T>(ProductDto ProductDto)
        {
            return await this.sendAsync<T>(new ApiRequest()
            {
                ApiType=SD.ApiType.POST,
                Data=ProductDto,
                Url=SD.productApiBase + "api/products",
                AccessToken=""

            });
        }

        public async Task<T> DeleteProductsAsync<T>(int id)
        {
            return await this.sendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.productApiBase + "api/products/"+id,
                AccessToken = ""

            });
        }

        public async Task<T> GetAllProductsAsync<T>()
        {
            return await this.sendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.productApiBase + "api/products" ,
                AccessToken = ""

            });
        }

        public async Task<T> GetProductsByIdAsync<T>(int id)
        {
            return await this.sendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.productApiBase + "api/products/"+id,
                AccessToken = ""

            });
        }

        public async Task<T> UpdateProductsAsync<T>(ProductDto ProductDto)
        {
            return await this.sendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = ProductDto,
                Url = SD.productApiBase + "api/products",
                AccessToken = ""

            });
        }
    }
}
