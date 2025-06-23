using System;

namespace ProductApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 12000,
                Discount = 10

            };
            Product product2 = new Product
            {
                Id = 2,
                Name = "Mobile",
                Price = 8000,
                Discount = 5
            };
            DisplayProductDetails(product1);
            Console.WriteLine();
            DisplayProductDetails(product2);
            Console.WriteLine();
        }

        static void DisplayProductDetails(Product product)
        {
            Console.WriteLine($"Id: {product.Id}");
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Price: {product.Price}");
            Console.WriteLine($"Discount: {product.Discount}");
            Console.WriteLine($"Final Price: {product.GetFinalPrice()}");
        }
        //nested product class
        class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public double Discount { get; set; }

            public decimal GetFinalPrice()
            {
                return Price - (Price * (decimal)Discount / 100);
            }

        }
    }
}

