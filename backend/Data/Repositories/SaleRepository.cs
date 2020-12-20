using System.Linq;
using Data;
using Domain.Models;
using Domain.Repositories;

namespace Data.Repositories
{
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        protected readonly SalesContext _context;
        public SaleRepository(SalesContext context) : base(context)
        {
            _context = context;
        }

    }
}