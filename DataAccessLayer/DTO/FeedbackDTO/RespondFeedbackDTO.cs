using DataAccessLayer.DTO.ProductDTO;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO.FeedbackDTO
{
    public class RespondFeedbackDTO
    {
        public string? Comment { get; set; }
        public string? Username { get; set; }

        public int? ProductId { get; set; }
        public RespondProductDTO ? Product { get; set; }
    }
}
