using Domain.Models;

namespace Domain.Repositories
{
    public interface ISalespersonRepository : IRepository<Salesperson>
    {
        public decimal GetSalespersonCommission(Salesperson salesperson);
    }
}