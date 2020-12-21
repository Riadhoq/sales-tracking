using System.Threading.Tasks;
using Data;
using Domain;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController: ControllerBase {
        private readonly ILogger<CustomerController> _logger;
        private IUnitOfWork _unitOfWork;
        public CustomerController(IUnitOfWork unitOfWork, ILogger<CustomerController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> Index(){
           return Ok(await _unitOfWork.Customers.GetAll());
        }

        [HttpGet("{customerId}")]
        public async Task<ActionResult> Index(int customerId){
           return Ok(await _unitOfWork.Customers.Get(customerId));
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> Index(Customer customer) {

            if(!ModelState.IsValid)
                return BadRequest();

            await _unitOfWork.Customers.Add(customer);
            await _unitOfWork.Complete();

            return Ok(customer);
        }

        [HttpPut("edit/{customerId}")]
        public async Task<ActionResult<Customer>> Edit([FromBody] Customer customer, [FromRoute] int customerId) {

            if(customer.CustomerId != customerId)
                return NotFound();
            if(!ModelState.IsValid)
                return BadRequest();

            _unitOfWork.Customers.Update(customer);
            await _unitOfWork.Complete();

            return Ok(customer);
        }
        
        [HttpPost("delete/{customerId}")]
        public async Task<ActionResult> Delete(int customerId) {

            var customer = await _unitOfWork.Customers.Get(customerId);
            if(customer == null)
                return NotFound();
            _unitOfWork.Customers.Remove(customer);
            await _unitOfWork.Complete();

            return Ok(customer);
        }

    }
}
