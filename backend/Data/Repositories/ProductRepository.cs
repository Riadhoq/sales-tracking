using System.Linq;
using Data;
using Domain.Models;
using Domain.Repositories;

namespace Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        protected readonly SalesContext _context;
        public ProductRepository(SalesContext context) : base(context)
        {
            _context = context;
        }

    }
}