namespace Domain.Models {
    public class Product {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Style { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int QuantityOnHand { get; set; }
        public decimal CommissionPercentage { get; set; }
    }
}