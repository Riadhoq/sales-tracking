using System.Threading.Tasks;
using Data;
using Data.Repositories;
using Domain;
using Domain.Repositories;

namespace Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SalesContext _context;

        public UnitOfWork(SalesContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
            Customers = new CustomerRepository(_context);
            Salespeople = new SalespersonRepository(_context);
            Discounts = new DiscountRepository(_context);
            Sales = new SaleRepository(_context);
        }

        public IProductRepository Products { get; private set; }
        public ICustomerRepository Customers { get; private set; }
        public ISalespersonRepository Salespeople { get; private set; }
        public IDiscountRepository Discounts { get; private set; }
        public ISaleRepository Sales { get; private set; }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}