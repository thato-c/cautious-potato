namespace Winehouse.Models
{
    public class CustomerProduct
    {
        public int CustomerProductId { get; set; }

        public int CustomerId { get; set; }

        public int ProductId { get; set; }

        public Product Products { get; set; }
        public Customer Customers { get; set; }
    }
}
