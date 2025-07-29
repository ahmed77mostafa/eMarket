using BusinessLogicLayer.Services.IService;
using DataAccessLayer.DTO.ProductDTO;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
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

        private readonly IProductService _service;
        private readonly IJwtService _jwtService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductService service, IJwtService jwtService, ILogger<ProductController> logger)
        {
            _service = service;
            _jwtService = jwtService;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInformation("Hi from action!");
            try
            {
                var products = await _service.getAll();
                if (products == null || !products.Any())
                {
                    return NotFound("No products found.");
                }
                return Ok(products);
            }
            catch (Exception ex)
            {
                // Log the exception (not shown here)
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving products.");
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(RequestProductDTO productDTO)
        {
            await _service.AddProduct(productDTO);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProducts(int id)
        {
            var product =  _service.DeleteProduct(id);
            if (product)
                return Ok("Done");
            return NotFound();
        }
    }   
}
