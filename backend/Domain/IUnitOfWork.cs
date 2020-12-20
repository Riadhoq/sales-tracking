using Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        ISalespersonRepository Salespeople { get; }
        ICustomerRepository Customers { get; }
        IDiscountRepository Discounts { get; }
        ISaleRepository Sales { get; }

        Task<int> Complete();
    }
}