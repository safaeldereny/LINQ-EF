using BookStoreEFProject1.Models;
using System;

namespace BookStoreEFProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new BookstoreDbContext();
            context.Books.Add(new Book { Title = "Test Book", Price = 10 });
            context.SaveChanges();
            Console.WriteLine("Book added successfully!");
        }
    }
}
