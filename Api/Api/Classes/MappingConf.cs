using AutoMapper;
using Db.Entitis;
using Lib.Dtos;

namespace Api.Classes
{
    public class MappingConf:Profile
    {
        public MappingConf()
        {
            CreateMap<CategoryDto,Category>();
            CreateMap<ProductDto, Product>();
            CreateMap<Product, GetProductDto>();
            CreateMap<Category, GetCategoryDto>();
        }

    }
}
