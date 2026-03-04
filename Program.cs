using System;
using System.Diagnostics;
using System.Linq;

namespace LINQAndEF02
{
    internal class Program
    {
        #region Problem01
        //static void Main(string[] args)
        //{
        //    // 1) Products that are out of stock
        //    var result1 = ListGenerators.ProductList
        //                    .Where(p => p.UnitsInStock == 0);

        //    Console.WriteLine("Out of Stock Products:");
        //    foreach (var product in result1)
        //    {
        //        Console.WriteLine(product.ProductName);
        //    }

        //    Console.WriteLine("--------------------------------");

        //    // 2) Products in stock and cost more than 3.00
        //    var result2 = ListGenerators.ProductList
        //                    .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

        //    Console.WriteLine("In Stock & Price > 3.00:");
        //    foreach (var product in result2)
        //    {
        //        Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
        //    }

        //    Console.WriteLine("--------------------------------");

        //    // 3) Digits whose name is shorter than their value
        //    string[] Arr = { "zero", "one", "two", "three", "four",
        //                     "five", "six", "seven", "eight", "nine" };

        //    var result3 = Arr
        //                  .Select((name, index) => new { Name = name, Value = index })
        //                  .Where(x => x.Value > x.Name.Length);

        //    Console.WriteLine("Digits whose name is shorter than value:");
        //    foreach (var item in result3)
        //    {
        //        Console.WriteLine(item.Name);
        //    }
        //}
        #endregion

        #region Problem02
        //static void Main(string[] args)
        //{

        //    Product firstOutOfStock =
        //        ListGenerators.ProductList
        //        .First(p => p.UnitsInStock == 0);

        //    Console.WriteLine(firstOutOfStock.ProductName);


        //    Product expensiveProduct =
        //        ListGenerators.ProductList
        //        .FirstOrDefault(p => p.UnitPrice > 1000);

        //    if (expensiveProduct != null)
        //        Console.WriteLine(expensiveProduct.ProductName);
        //    else
        //        Console.WriteLine("No product found");


        //    int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //    int secondNumber =
        //        Arr.Where(x => x > 5)
        //           .ElementAt(1);

        //    Console.WriteLine(secondNumber);
        //}
        #endregion

        #region Problem03
        //static void Main()
        //{
        //    int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //// 1. Uses Count to get the number of odd numbers in the array 
        //int oddCount = Arr.Count(x => x % 2 != 0);
        //    Console.WriteLine("Number of odd numbers: " + oddCount);

        //// 2. Return a list of customers and how many orders each has. 
        //var customerOrdersCount = ListGenerators.Customers
        //        .Select(c => new
        //        {
        //            CustomerName = c.CustomerName,
        //            OrdersCount = c.Orders.Count
        //        });
        //    foreach (var item in customerOrdersCount)
        //        Console.WriteLine($"{item.CustomerName} has {item.OrdersCount} orders");

        //// 3. Return a list of categories and how many products each has 
        //var categoryProductCount = ListGenerators.ProductList
        //        .GroupBy(p => p.Category)
        //        .Select(g => new
        //        {
        //            Category = g.Key,
        //            ProductsCount = g.Count()
        //        });
        //    foreach (var item in categoryProductCount)
        //        Console.WriteLine($"{item.Category}: {item.ProductsCount} products");

        //// 4. Get the total of the numbers in an array. 
        //int total = Arr.Sum();
        //    Console.WriteLine("Total of numbers: " + total);

        //// 5. Get the total number of characters of all words in dictionary_english.txt (Read
        ////dictionary_english.txt into Array of String First).

        //    string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");
        //    int totalChars = words.Sum(word => word.Length);
        //    Console.WriteLine("Total number of characters: " + totalChars);
        //}
        #endregion

        #region Problem04
        //static void Main(string[] args)
        //{
        //    // 1️- Sort a list of products by name
        //    Console.WriteLine("1) Products sorted by name:");
        //    var sortedByName = ListGenerators.ProductList
        //                         .OrderBy(p => p.ProductName);
        //    foreach (var p in sortedByName)
        //        Console.WriteLine(p.ProductName);

        //    Console.WriteLine("--------------------------------");

        //// 2️- case-insensitive sort of the words in an array. 
        //string[] Arr1 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //    Console.WriteLine("2) Case-insensitive sort of words:");
        //    var sortedCaseInsensitive = Arr1
        //                                .OrderBy(s => s, StringComparer.OrdinalIgnoreCase);
        //    foreach (var s in sortedCaseInsensitive)
        //        Console.WriteLine(s);

        //    Console.WriteLine("--------------------------------");

        //// 3- Sort a list of products by units in stock from highest to lowest.
        //Console.WriteLine("3) Products sorted by units in stock (desc):");
        //    var sortedByStockDesc = ListGenerators.ProductList
        //                               .OrderByDescending(p => p.UnitsInStock);
        //    foreach (var p in sortedByStockDesc)
        //        Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");

        //    Console.WriteLine("--------------------------------");

        //// 4️- Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
        //    string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        //    Console.WriteLine("4) Digits sorted by length then alphabetically:");
        //    var sortedDigits = digits
        //                       .OrderBy(d => d.Length)
        //                       .ThenBy(d => d);
        //    foreach (var d in sortedDigits)
        //        Console.WriteLine(d);

        //    Console.WriteLine("--------------------------------");

        //// 5️⃣ . Sort first by word length and then by a case-insensitive sort of the words in an array. 
        //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //    Console.WriteLine("5) Words sorted by length then case-insensitive:");
        //    var sortedWords = words
        //                      .OrderBy(w => w.Length)
        //                      .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
        //    foreach (var w in sortedWords)
        //        Console.WriteLine(w);

        //    Console.WriteLine("--------------------------------");

        //// 6️- Sort a list of products, first by category, and then by unit price, from highest to lowest.
        //Console.WriteLine("6) Products sorted by category then unit price desc:");
        //    var sortedByCategoryPrice = ListGenerators.ProductList
        //                                   .OrderBy(p => p.Category)
        //                                   .ThenByDescending(p => p.UnitPrice);
        //    foreach (var p in sortedByCategoryPrice)
        //        Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");

        //    Console.WriteLine("--------------------------------");

        //// 7️- Sort first by word length and then by a case-insensitive descending sort of the words in an array. 
        //    string[] Arr2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //    Console.WriteLine("7) Words sorted by length then case-insensitive descending:");
        //    var sortedWordsDesc = Arr2
        //                          .OrderBy(w => w.Length)
        //                          .ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
        //    foreach (var w in sortedWordsDesc)
        //        Console.WriteLine(w);

        //    Console.WriteLine("--------------------------------");

        //// 8️- Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
        //    string[] digits2 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        //    Console.WriteLine("8) Digits whose second letter is 'i', reversed:");
        //    var filteredReversed = digits2
        //                           .Where(d => d.Length > 1 && d[1] == 'i')
        //                           .Reverse();
        //    foreach (var d in filteredReversed)
        //        Console.WriteLine(d);
        //}
        #endregion

        #region Problem05
            static void Main(string[] args)
            {
            // 1️- Return a sequence of just the names of a list of products
            Console.WriteLine("1) Product Names:");
                var productNames = ListGenerators.ProductList
                                      .Select(p => p.ProductName);
                foreach (var name in productNames)
                    Console.WriteLine(name);

                Console.WriteLine("--------------------------------");

            // 2️-  Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types). 
                string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
                Console.WriteLine("2) Uppercase and lowercase versions:");
                var upperLower = words
                                 .Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
                foreach (var item in upperLower)
                    Console.WriteLine($"Upper: {item.Upper}, Lower: {item.Lower}");

                Console.WriteLine("--------------------------------");

                // 3️-  Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
                Console.WriteLine("3) Product properties with Price:");
                var productProps = ListGenerators.ProductList
                                    .Select(p => new { p.ProductName, Price = p.UnitPrice, p.UnitsInStock });
                foreach (var item in productProps)
                    Console.WriteLine($"{item.ProductName} - Price: {item.Price}, UnitsInStock: {item.UnitsInStock}");

                Console.WriteLine("--------------------------------");


            // 4️- Determine if the value of ints in an array match their position in the array
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                Console.WriteLine("4) Number: In-place?");
                var inPlace = Arr.Select((value, index) => new { Value = value, InPlace = value == index });
                foreach (var item in inPlace)
                    Console.WriteLine($"{item.Value}: {item.InPlace}");

                Console.WriteLine("--------------------------------");

            // 5️- Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            
                            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
                int[] numbersB = { 1, 3, 5, 7, 8 };
                Console.WriteLine("5) Pairs where a < b:");
                var pairs = numbersA
                            .SelectMany(a => numbersB, (a, b) => new { a, b })
                            .Where(pair => pair.a < pair.b);
                foreach (var pair in pairs)
                    Console.WriteLine($"{pair.a} is less than {pair.b}");

                Console.WriteLine("--------------------------------");

            // 6️- Select all orders where the order total is less than 500.00. 
            Console.WriteLine("6) Orders with total < 500.00:");
                var smallOrders = ListGenerators.Customers
                                  .SelectMany(c => c.Orders, (c, o) => new { Customer = c.CustomerName, Order = o })
                                  .Where(x => x.Order.Total < 500.00m); // نفترض كل Order له Total property
                foreach (var item in smallOrders)
                    Console.WriteLine($"{item.Customer} - OrderID: {item.Order.OrderID}, Total: {item.Order.Total}");

            Console.WriteLine("--------------------------------");

            // 7️-  Select all orders where the order was made in 1998 or later. 
            Console.WriteLine("7) Orders from 1998 or later:");
                var ordersAfter1998 = ListGenerators.Customers
                                       .SelectMany(c => c.Orders, (c, o) => new { Customer = c.CustomerName, Order = o })
                                       .Where(x => x.Order.OrderDate.Year >= 1998); // نفترض Order لديه OrderDate property
                foreach (var item in ordersAfter1998)
                    Console.WriteLine($"{item.Customer} - OrderID: {item.Order.OrderID}, Date: {item.Order.OrderDate.ToShortDateString()}");
            }
    #endregion
}

}