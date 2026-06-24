using AutoMapper;
using Db.Base;
using Db.Entitis;
using Lib.Base;
using Lib.Dtos;

namespace Api.Services
{
    public class CategoryServices(IGenralRepos<Category> category, IMapper mapper) : ICategoryService
    {
        public async Task<ResponseDto> AddCategoryAsync(CategoryDto categoryDto)
        {
            var categoryEntity = mapper.Map<Category>(categoryDto);
            int result =  await category.AddAsync(categoryEntity);
            if (result > 0)
            {
                return new ResponseDto { IsSucces = true, Msg = "Category added successfully." };
            }
            else
            {
                return new ResponseDto { IsSucces = false, Msg = "Failed to add category." };
            }

        }

        public Task<ResponseDto> DeleteCategoryAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetCategoryDto>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetCategoryDto> GetCategoryByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
