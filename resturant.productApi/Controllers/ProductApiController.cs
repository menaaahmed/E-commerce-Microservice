using Microsoft.AspNetCore.Mvc;
using resturant.productApi.Models;
using resturant.productApi.Models.Dto;
using resturant.productApi.Repository;

namespace resturant.productApi.Controllers
{
    [Route("api/products")]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductRepository _productRepositpry;
        protected ResponseDto _response;

        public ProductApiController(IProductRepository productRepositpry)
        {
            _productRepositpry = productRepositpry;
            this._response = new ResponseDto();
        }
        // 5 crud operations for api(get,post,put,delete)

        //getAll
        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<ProductDto> productDtos = await _productRepositpry.GetProducts();
                _response.Result=productDtos;

            }
            catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMsg = new List<string>(){ex.ToString() };
                    
            }
            return _response;   
        }

        //getById
        [HttpGet]
        [Route("{id}")]
        public async Task<object> Get(int id)
        {
            try
            {
                ProductDto ProductDto = await _productRepositpry.GetProductsById(id );
                _response.Result = ProductDto;

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMsg = new List<string>() { ex.ToString() };

            }
            return _response;
        }

        //create
        [HttpPost]
        public async Task<object> Post([FromBody] ProductDto ProductDto)
        {
            try
            {
                ProductDto model = await _productRepositpry.CreateProducts(ProductDto);
                _response.Result = model;

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMsg = new List<string>() { ex.ToString() };

            }
            return _response;
        }

        //update
        [HttpPut]
        public async Task<object> Put([FromBody] ProductDto ProductDto)
        {
            try
            {
                ProductDto model = await _productRepositpry.UpdateProducts(ProductDto);
                _response.Result = model;

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMsg = new List<string>() { ex.ToString() };

            }
            return _response;
        }

        //delete
        [HttpDelete]
        public async Task<object> Delete(int id)
        {
            try
            {
                bool isSuccess = await _productRepositpry.DeleteProducts(id);
                _response.Result = isSuccess;

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMsg = new List<string>() { ex.ToString() };

            }
            return _response;
        }
    }
    
}
