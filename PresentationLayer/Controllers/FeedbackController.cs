using AutoMapper;
using DataAccessLayer.DTO.FeedbackDTO;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Task1.Data;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController: ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;

        public FeedbackController(IMapper mapper, AppDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpPost]
        public IActionResult AddFeedback(RequestFeedbackDTO feedbackDTO)
        {
            var insertMapper = _mapper.Map<Feedback>(feedbackDTO);

            _context.Feedbacks.Add(insertMapper);
            _context.SaveChanges();

            return Ok();
        }
    }
}
