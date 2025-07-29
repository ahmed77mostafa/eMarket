using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO.ProductDTO
{
    public class RespondProductDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public double? Price { get; set; }
        [Required]
        public string? Image { get; set; }
        public int? CategroyId { get; set; }
        public RespondProductDTO? Category { get; set; }

        public List<Feedback> Feedbacks { get; set; }
    }
}
