using AutoMapper;
using Microsoft.EntityFrameworkCore;
using resturant.productApi.DbContexts;
using resturant.productApi.Models;
using resturant.productApi.Models.Dto;

namespace resturant.productApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        //CREATE
        public async Task<ProductDto> CreateProducts(ProductDto ProductDto)
        {
            Product createdProduct = _mapper.Map<ProductDto, Product>(ProductDto);
            _db.Products.Add(createdProduct);
            await _db.SaveChangesAsync();
            return _mapper.Map<Product,ProductDto>(createdProduct);
        }

        //DELETE
        public async Task<bool> DeleteProducts(int ProductId)
        {
            try
            {
                Product deletedProduct = await _db.Products.Where(x => x.ProductId == ProductId)
                .FirstOrDefaultAsync();
                if(deletedProduct == null)
                {
                    return false;
                }
                _db.Products.Remove(deletedProduct);
                await _db.SaveChangesAsync();
                return true;
            }
            catch(Exception )
            {
                return false;
            }
        }

        //GET ALL
        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            List<Product> productList = await _db.Products.ToListAsync();
            return _mapper.Map<List<ProductDto>>(productList);
        }

        //GET BY ID
        public async Task<ProductDto> GetProductsById(int ProductId)
        {
            Product singleProduct = await _db.Products.Where(x=>x.ProductId== ProductId)
                .FirstOrDefaultAsync();
            return _mapper.Map<ProductDto>(singleProduct);
        }

        //UPDATE
        public async Task<ProductDto> UpdateProducts(ProductDto ProductDto)
        {
            Product updatedProduct = _mapper.Map<Product>(ProductDto);
            _db.Products.Update(updatedProduct);
            await _db.SaveChangesAsync();
            return _mapper.Map<ProductDto>(updatedProduct);
        }
    }
}
