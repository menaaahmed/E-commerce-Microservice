using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Resturant.web.Models;
using Resturant.web.services.IServices;

namespace Resturant.web.Controllers
{
    public class productController : Controller
    {
        private readonly IProductService _productService;

        public productController( IProductService productService)
        {
            _productService = productService;

        }
        public async Task<IActionResult> productIndex()
        {
            List<ProductDto> productList = new ();
            var response = await _productService.GetAllProductsAsync<ResponseDto>();
            if(response != null && response.IsSuccess)
            {
                productList = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            }
            return View(productList);
        }

        public async Task<IActionResult> productCreate()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> productCreate(ProductDto model)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.CreateProductsAsync<ResponseDto>(model);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(productIndex));
                }
            }
                return View(model);
            
        }

        public async Task<IActionResult> productEdit(int ProductId)
        {
            var response = await _productService.GetProductsByIdAsync<ResponseDto>(ProductId);
            if (response != null && response.IsSuccess)
            {
                ProductDto model = JsonConvert.DeserializeObject<ProductDto>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> productEdit(ProductDto model)
        {
            var response = await _productService.UpdateProductsAsync<ResponseDto>(model);
            if (response != null && response.IsSuccess)
            {
                return RedirectToAction(nameof(productIndex));
            }
            return View(model);
        }

        public async Task<IActionResult> productRemove(int ProductId)
        {
            var response = await _productService.GetProductsByIdAsync<ResponseDto>(ProductId);
            if (response != null && response.IsSuccess)
            {
                ProductDto model = JsonConvert.DeserializeObject<ProductDto>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> productRemove(ProductDto model)
        {
            var response = await _productService.DeleteProductsAsync<ResponseDto>(model.ProductId);
            if (response != null && response.IsSuccess)
            {
                return RedirectToAction(nameof(productIndex));
            }
            return View(model);
        }
    }
}
