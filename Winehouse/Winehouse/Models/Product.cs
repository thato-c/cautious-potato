namespace Winehouse.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Product_Name { get; set; } = string.Empty;

        public string Product_Description { get; set; } = string.Empty;

        public string? Product_Category { get; set; }

        public string Product_Brand { get; set; } = string.Empty;

        public int Product_Price { get; set; } = 0;
    }
}
