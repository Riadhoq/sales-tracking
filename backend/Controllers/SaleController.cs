using System.Threading.Tasks;
using Data;
using Domain;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/sales")]
    public class SaleController: ControllerBase {
        private readonly ILogger<SaleController> _logger;
        private IUnitOfWork _unitOfWork;
        public SaleController(IUnitOfWork unitOfWork, ILogger<SaleController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> Index(){
           return Ok(await _unitOfWork.Sales.GetAll());
        }

        [HttpGet("{saleId}")]
        public async Task<ActionResult> Index(int saleId){
           return Ok(await _unitOfWork.Sales.Get(saleId));
        }

        [HttpPost]
        public async Task<ActionResult<Sale>> Index(Sale sale) {

            if(!ModelState.IsValid)
                return BadRequest();
            try
            {
                // await Task.Run(() => _unitOfWork.Sales.Add(sale));
                await _unitOfWork.Sales.Add(sale);
                await _unitOfWork.Complete();
                return Ok(sale);
            }
            catch (System.Exception ex)
            {
                _unitOfWork.Dispose();
                return BadRequest(new { Error = ex.Message });
            }
 
        }

    }
}
