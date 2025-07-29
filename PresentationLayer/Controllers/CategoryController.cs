using AutoMapper;
using BusinessLogicLayer.Services.IService;
using DataAccessLayer.DTO.CategoryDTO;
using DataAccessLayer.Entities;
using DataAccessLayer.Filters;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task1.Data;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        private readonly ILogger<CategoryController> _logger;
        public CategoryController(ILogger<CategoryController> logger, ICategoryService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        //[LogSensitiveAction]
        public async Task<IActionResult> GetAllCategories()
        {
            _logger.LogInformation("Fetching all categories.");
            var categories = await _service.GetAllCategories();
            return Ok(categories);
        }
        

        [HttpGet]
        [Route("{key}")]
        public IActionResult GetById([FromRoute(Name = "key")] int id)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult AddCategory(RequestCategoryDTO categoryDTO)
        {
            //var insertMapper = _mapper.Map<Category>(categoryDTO);

            //if (insertMapper == null)
                return NotFound();

            //_context.Categories.Add(insertMapper);
            //_context.SaveChanges();

            return Ok();
        }

    }
}
