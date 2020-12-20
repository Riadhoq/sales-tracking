using System.Linq;
using Data;
using Domain.Models;
using Domain.Repositories;

namespace Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        protected readonly SalesContext _context;
        public CustomerRepository(SalesContext context) : base(context)
        {
            _context = context;
        }

    }
}