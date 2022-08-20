using AutoMapper;
using resturant.productApi.Models;
using resturant.productApi.Models.Dto;

namespace resturant.productApi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig=new MapperConfiguration(Config =>
            {
                Config.CreateMap<ProductDto,Product>();
                Config.CreateMap<Product, ProductDto>();
            });


            return mappingConfig;
        }
    }
}
