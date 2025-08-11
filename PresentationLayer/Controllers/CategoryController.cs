using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly IBaseRepository<Category> _categoryRepo;
        public CategoryController(ILogger<CategoryController> logger, IBaseRepository<Category> categoryRepo)
        {
            _logger = logger;
            _categoryRepo = categoryRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryRepo.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        //[LogSensitiveAction]

        #region
        //[HttpGet]
        //[Route("{key}")]
        //public IActionResult GetById([FromRoute(Name = "key")] int id)
        #endregion

        [HttpGet("GetByName")]
        public async Task<IActionResult> GetByName(string name)
        {
            return Ok(await _categoryRepo.Find(c => c.Name == name, new[] {"Products"}));
        }
        
    }
}
