using DataAccessLayer.DTO.CategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.IService
{
    public interface ICategoryService
    {
        Task<IEnumerable<RespondCategoryDTO>> GetAllCategories();
    }
}
