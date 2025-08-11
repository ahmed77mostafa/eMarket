using BusinessLogicLayer.Consts;
using BusinessLogicLayer.Services.IService;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region wwwroot(Add Image)
        //var imageName = Guid.NewGuid().ToString() + Path.GetExtension(product_Dtos.Image.FileName);
        //    var imagePath = Path.Combine("wwwroot/Images", imageName);

        //    // Ensure the directory exists
        //    Directory.CreateDirectory("wwwroot/Images");

        //    // 3. Save the image to disk
        //    using (var stream = new FileStream(imagePath, FileMode.Create))
        //    {
        //        product_Dtos.Image.CopyTo(stream);
        //    }

        //    // 4. Map and assign image path
        //    var product = _mapper.Map<Product>(product_Dtos);
        //    product.Image = "/Images/" + imageName;

        //    // 5. Save product
        //    _repo.AddProduct(product);
        #endregion  

        private readonly IBaseRepository<Product> _productRepo;
        private readonly IJwtService _jwtService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IJwtService jwtService, ILogger<ProductController> logger, IBaseRepository<Product> productRepo)
        {
            _jwtService = jwtService;
            _logger = logger;
            _productRepo = productRepo;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _productRepo.GetById(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(await _productRepo.GetAll());
        }
        [HttpGet("GetOrdered")]
        public IActionResult GetOrdered()
        {
            return Ok(_productRepo.FindAllAsync(b => b.Name.Contains("p"), null, null, b => b.Id, OrderBy.Descending));
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest("Product cannot be null");
            }

            await _productRepo.Add(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }
        [HttpPost("AddRange")]
        public async Task<IActionResult> AddRange(IEnumerable<Product> products)
        {
            if (products == null || !products.Any())
            {
                return BadRequest("Products cannot be null or empty");
            }

            await _productRepo.AddRange(products);
            return CreatedAtAction(nameof(GetAllProducts), products);
        }

    }
}
