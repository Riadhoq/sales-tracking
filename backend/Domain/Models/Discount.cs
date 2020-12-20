using System;

namespace Domain.Models {
    public class Discount {
        public int DiscountId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTimeOffset BeginDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public decimal DiscountPercentage { get; set; }
    }
}