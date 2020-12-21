using System;
using System.Linq;
using Data;
using Domain.Models;
using Domain.Repositories;
using Microsoft.Extensions.Logging;

namespace Data.Repositories
{
    public class SalespersonRepository : Repository<Salesperson>, ISalespersonRepository
    {
        protected readonly SalesContext _context;

        public SalespersonRepository(SalesContext context) : base(context)
        {
            _context = context;
        }

        public decimal GetSalespersonCommission(Salesperson salesperson){

            var query = _context.Salespeople
                                .Join(_context.Sales, 
                                        salesperson => salesperson.SalespersonId, 
                                        sale => sale.SalespersonId, 
                                        (salesperson, sale) => new { SalespersonId= sale.SalespersonId, Commission = sale.Product.SalePrice * (sale.Product.CommissionPercentage / 100) });
                                        
            return query.Where(s => s.SalespersonId==salesperson.SalespersonId).Sum(x => x.Commission);
        }

    }
}