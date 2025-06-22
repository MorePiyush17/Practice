using System;
using System.Diagnostics;
using Mysolutions;

namespace Mysolutions
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public bool IsBestseller { get; set; }

        public double CalculateDiscountedPrice()
        {
            double discountPrice = Price;
            if (IsBestseller)
            {
                Console.WriteLine($"{Title} is a bestseller. Apply 10% discount.");
                discountPrice *= 0.90;
            }
            if (Price > 500)
            {
                Console.WriteLine($"{Title} is priced over 500. Apply 5% discount.");
                discountPrice *= 0.95;
            }
            return discountPrice;
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        var book1 = new Book
        {
            Title = "The Power of Habit",
            Author = "Charles Duhigg",
            Price = 600.00,
            IsBestseller = true
        };

        var book2 = new Book
        {
            Title = "C# Programming",
            Author = "Jane Doe",
            Price = 450.00,
            IsBestseller = false
        };

        // Book 1
        Console.WriteLine($"Title: {book1.Title}");
        Console.WriteLine($"Author: {book1.Author}");
        Console.WriteLine($"Original Price: ${book1.Price}");
        double discounted1 = book1.CalculateDiscountedPrice();
        Console.WriteLine($"Discounted Price: ${discounted1}\n");

        // Book 2
        Console.WriteLine($"Title: {book2.Title}");
        Console.WriteLine($"Author: {book2.Author}");
        Console.WriteLine($"Original Price: ${book2.Price}");
        double discounted2 = book2.CalculateDiscountedPrice();
        Console.WriteLine($"Discounted Price: ${discounted2}\n");

        Console.ReadLine();
    }
}