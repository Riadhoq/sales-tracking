using System.Threading.Tasks;
using Data;
using Domain;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/salespeople")]
    public class SalespersonController: ControllerBase {
        private readonly ILogger<SalespersonController> _logger;
        private IUnitOfWork _unitOfWork;
        public SalespersonController(IUnitOfWork unitOfWork, ILogger<SalespersonController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> Index(){
           return Ok(await _unitOfWork.Salespeople.GetAll());
        }

        [HttpGet("{salespersonId}")]
        public async Task<ActionResult> Index(int salespersonId){
           return Ok(await _unitOfWork.Salespeople.Get(salespersonId));
        }

        [HttpPost]
        public async Task<ActionResult<Salesperson>> Index(Salesperson salesperson) {

            if(!ModelState.IsValid)
                return NoContent();

            _unitOfWork.Salespeople.Add(salesperson);
            await _unitOfWork.Complete();

            return Ok(salesperson);
        }

        [HttpPut("edit/{salespersonId}")]
        public async Task<ActionResult<Salesperson>> Edit([FromBody] Salesperson salesperson, [FromRoute] int salespersonId) {

            if(salesperson.SalespersonId != salespersonId)
                return NotFound();
            if(!ModelState.IsValid)
                return BadRequest();

            _unitOfWork.Salespeople.Update(salesperson);
            await _unitOfWork.Complete();

            return Ok(salesperson);
        }
        
        [HttpPost("delete/{salespersonId}")]
        public async Task<ActionResult> Delete(int salespersonId) {

            var salesperson = await _unitOfWork.Salespeople.Get(salespersonId);
            if(salesperson == null)
                return NotFound();
            _unitOfWork.Salespeople.Remove(salesperson);
            await _unitOfWork.Complete();

            return Ok(salesperson);
        }

    }
}
