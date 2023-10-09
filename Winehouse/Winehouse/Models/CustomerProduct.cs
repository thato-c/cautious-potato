namespace Winehouse.Models
{
    public class CustomerProduct
    {
        public int CustomerProductId { get; set; }

        public int CustomerId { get; set; }

        public int ProductId { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
