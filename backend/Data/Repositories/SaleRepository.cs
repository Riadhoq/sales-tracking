using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Domain.Models;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        protected readonly SalesContext _context;
        public SaleRepository(SalesContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Sale>> GetAll()
        {
            return await _context.Sales
                                    .Include(sale => sale.Product)
                                    .Include(sale => sale.Salesperson)
                                    .Include(sale => sale.Customer)
                                    .ToListAsync();
        }

        public override async Task Add(Sale sale) {

            var transaction =_context.Database.BeginTransaction();
            
            var product = _context.Products.Find(sale.ProductId);
            if(product == null || product.QuantityOnHand <= 0) {
                throw new NotSupportedException("Product is not available");
            }

            try {
                product.QuantityOnHand -= 1;
                _context.SaveChanges();
                sale.SalesDate = DateTimeOffset.Now;
                await _entities.AddAsync(sale);
                await transaction.CommitAsync();
            } catch {
                await transaction.RollbackAsync();
                throw new Exception("Sale could not be added");
            }
        }
    }
}