using DataAccessLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.DTO.FeedbackDTO
{
    public class RequestFeedbackDTO
    {
        public string? Comment { get; set; }
        public string? Username { get; set; }

        public int? ProductId { get; set; }
    }
}
