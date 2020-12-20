using System;

namespace Domain.Models {
    public class Sale {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int SalespersonId { get; set; }
        public Salesperson Salesperson { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTimeOffset SalesDate { get; set; }
    }
}