using DataAccessLayer.DTO.FeedbackDTO;
using DataAccessLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.DTO.ProductDTO
{
    public class RequestProductDTO
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public double? Price { get; set; }
        [Required]
        public string? Image { get; set; }
        public int? CategroyId { get; set; }
        public List<FeedbackAtProduct> Feedbacks { get; set; }
    }
}
