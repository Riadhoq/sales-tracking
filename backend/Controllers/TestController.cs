using System.Threading.Tasks;
using Data;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/Test")]
    public class TestController: ControllerBase {
        private readonly ILogger<TestController> _logger;
        private UnitOfWork _unitOfWork;
        public TestController(SalesContext context, ILogger<TestController> logger)
        {
            _unitOfWork = new UnitOfWork(context);
            _logger = logger;
        }

        [HttpGet("products")]
        public async Task<ActionResult> Get(){
           return Ok(await _unitOfWork.Products.GetAll());
        }
    }
}
