using System.Linq;
using Data;
using Domain.Models;
using Domain.Repositories;

namespace Data.Repositories
{
    public class DiscountRepository : Repository<Discount>, IDiscountRepository
    {
        protected readonly SalesContext _context;
        public DiscountRepository(SalesContext context) : base(context)
        {
            _context = context;
        }

    }
}