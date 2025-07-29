using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        public string? Comment { get; set; }
        public string? Username { get; set; }
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
