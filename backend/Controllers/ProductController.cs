using System.Threading.Tasks;
using Data;
using Domain;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController: ControllerBase {
        private readonly ILogger<TestController> _logger;
        private IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork, ILogger<TestController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> Index(){
           return Ok(await _unitOfWork.Products.GetAll());
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult> Index(int productId){
           return Ok(await _unitOfWork.Products.Get(productId));
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Index(Product product) {

            if(!ModelState.IsValid)
                return NoContent();

            _unitOfWork.Products.Add(product);
            await _unitOfWork.Complete();

            return Ok(product);
        }

        [HttpPut("edit/{productId}")]
        public async Task<ActionResult<Product>> Edit([FromBody] Product product, [FromRoute] int productId) {

            if(product.ProductId != productId)
                return NotFound();
            if(!ModelState.IsValid)
                return BadRequest();

            _unitOfWork.Products.Update(product);
            await _unitOfWork.Complete();

            return Ok(product);
        }
        
        [HttpPost("delete/{productId}")]
        public async Task<ActionResult> Delete(int productId) {

            var product = await _unitOfWork.Products.Get(productId);
            if(product == null)
                return NotFound();
            _unitOfWork.Products.Remove(product);
            await _unitOfWork.Complete();

            return Ok(product);
        }

    }
}
