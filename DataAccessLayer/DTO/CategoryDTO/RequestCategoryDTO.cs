using DataAccessLayer.DTO.ProductDTO;
using DataAccessLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.DTO.CategoryDTO
{
    public class RequestCategoryDTO
    {
        [Required]
        public string? Name { get; set; }
        public List<RequestProductDTO>? Products { get; set; }
    }
}
