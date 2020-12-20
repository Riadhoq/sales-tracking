using System.Linq;
using Data;
using Domain.Models;
using Domain.Repositories;

namespace Data.Repositories
{
    public class SalespersonRepository : Repository<Salesperson>, ISalespersonRepository
    {
        protected readonly SalesContext _context;
        public SalespersonRepository(SalesContext context) : base(context)
        {
            _context = context;
        }

    }
}