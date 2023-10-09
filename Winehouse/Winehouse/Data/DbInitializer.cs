using Winehouse.Models;

namespace Winehouse.Data
{
    public class DbInitializer
    {
        public static void Initialize(StoreContext context) 
        { 
            context.Database.EnsureCreated();

            // Add Customers
            if (context.Customers.Any())
            {
                return;
            }

            var customers = new Customer[]
            {
                new Customer { CustomerName = "Albert", CustomerEmail = "albert@gmaail.com" },
                new Customer { CustomerName = "John Smith", CustomerEmail = "john.smith@example.com" },
                new Customer { CustomerName = "Alice Johnson", CustomerEmail = "alice.johnson@example.com" },
                new Customer { CustomerName = "Bob Wilson", CustomerEmail = "bob.wilson@example.com" },
                new Customer { CustomerName = "Emily Davis", CustomerEmail = "emily.davis@example.com" },
                new Customer { CustomerName = "Michael Brown", CustomerEmail = "michael.brown@example.com" },
                new Customer { CustomerName = "Sara Lee", CustomerEmail = "sara.lee@example.com" },
                new Customer { CustomerName = "David Johnson", CustomerEmail = "david.johnson@example.com" },
                new Customer { CustomerName = "Laura Miller", CustomerEmail = "laura.miller@example.com" },
            };

            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }

            var products = new Product[]
            {
                new Product
                {
                    Product_Name = "Acoustic Guitar",
                    Product_Description = "A high-quality acoustic guitar for musicians.",
                    Product_Category = "Musical Instruments",
                    Product_Brand = "Fender",
                    Product_Price = 800
                },
                new Product
                {
                    Product_Name = "Electric Keyboard",
                    Product_Description = "An electric keyboard with various sound options.",
                    Product_Category = "Keyboards",
                    Product_Brand = "Yamaha",
                    Product_Price = 1200
                },
                new Product
                {
                    Product_Name = "Drum Kit",
                    Product_Description = "A complete drum kit for drummers and percussionists.",
                    Product_Category = "Drums",
                    Product_Brand = "Pearl",
                    Product_Price = 1500
                },
                new Product
                {
                    Product_Name = "Microphone Set",
                    Product_Description = "A set of professional microphones for recording and live performances.",
                    Product_Category = "Audio Equipment",
                    Product_Brand = "Shure",
                    Product_Price = 500
                },
                new Product
                {
                    Product_Name = "Amplifier",
                    Product_Description = "A powerful amplifier for enhancing your music's sound.",
                    Product_Category = "Amplifiers",
                    Product_Brand = "Marshall",
                    Product_Price = 700
                },
            };

            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
        }
    }
}
