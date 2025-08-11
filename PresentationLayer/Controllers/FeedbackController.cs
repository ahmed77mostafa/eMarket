using AutoMapper;
using DataAccessLayer.DTO.FeedbackDTO;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Task1.Data;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController: ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<Feedback> _feedbackRepo;
        public FeedbackController(IMapper mapper, IBaseRepository<Feedback> feedbackRepo)
        {
            _mapper = mapper;
            _feedbackRepo = feedbackRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _feedbackRepo.GetById(id));
        }

        [HttpGet("GetByName")]
        public async Task<IActionResult> GetByName(string name)
        {
            return Ok(await _feedbackRepo.FindAll(c => c.Username.Contains(name), new[] { "Product" }));
        }
    }
}
