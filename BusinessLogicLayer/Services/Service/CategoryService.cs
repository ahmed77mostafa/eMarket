using AutoMapper;
using BusinessLogicLayer.Services.IService;
using DataAccessLayer.DTO.CategoryDTO;
using DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _repo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RespondCategoryDTO>> GetAllCategories()
        {
            var categories = await _repo.GetAllCategoriesAsync();
            return _mapper.Map<IEnumerable<RespondCategoryDTO>>(categories);
        }
    }
}
