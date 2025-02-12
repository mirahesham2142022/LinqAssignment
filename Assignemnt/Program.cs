using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Reflection;
using static LinqDemo.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static LinqDemo.ListGenerator;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml.Linq;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlTypes;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:/Users/XPRISTO/LinqSession2Demo/Assignemnt/dictionary_english.txt";
            string[] words=File.ReadAllLines(filePath);

            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock
            var res = ProductList.Where(p => p.UnitsInStock == 0).FirstOrDefault();
            Console.WriteLine(res);
            #endregion
            #region   2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //res = ProductList.Where(p => p.UnitPrice > 1000).FirstOrDefault();
            //Console.WriteLine(res);
            //Console.WriteLine(res?.ProductName??"NA");

            #endregion
            #region    3.Retrieve the second number greater than 5
            List<int> numbers = new List<int>()
              {
                    1,2, 3, 4,5,6,7,9,45
              };
            var res1 = numbers.Where(n => n > 5).ElementAt(1);
            Console.WriteLine(res1);
            #endregion
            #endregion

            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var rse2 = Arr.Where(a => a % 2 == 1).Count();
            //Console.WriteLine(rse2);
            #endregion

            #region 2. Return a list of customers and how many orders each has.
            var Orders = new List<Order>()
            {
                new Order(1,new DateTime(1/12024),5000,1),
                new Order(2,new DateTime(1/12024),5000,4),
                new Order(3,new DateTime(1/12024),5000,3),
                new Order(4,new DateTime(1/12024),5000,2),


            };
            //var CountOfCustomersOrders = Orders.OrderBy(o => o.customerId)
            //                            .ToList().Count(o => o.customerId);
            //foreach(var Res in CountOfCustomersOrders)
            //{
            //    Console.WriteLine(Res);
            //}
            #endregion

            #region 3. Return a list of categories and how many products each has
            //var ress = ProductList.OrderBy(p=>p.Category)
            //              .Count();
            //Console.WriteLine(ress);
            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var sum1 = Arr1.Sum();
            //Console.WriteLine(sum1);
            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).



            #endregion
            #region 9. Get the total units in stock for each product category.
            //var res6 = ProductList .GroupBy(p => p.Category)
            //   .Select(g => new { Category = g.Key, TotalStock = g.Sum(p => p.UnitsInStock) });

            //foreach (var o in res6)
            //{
            //    Console.WriteLine($"Category{o.Category}, Total Units{o.TotalStock}");
            //}
            #endregion
            #region             10.Get the cheapest price among each category's products

            //var res7 = ProductList.GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key ,Minimum=g.Min(p=>p.UnitPrice)});
            //foreach(var min in res7)
            //{
            //    Console.WriteLine( $"{min.Category},{min.Minimum}");
            //}
            #endregion
            Console.WriteLine("******************");
            #region   11.Get the products with the cheapest price in each category(Use Let)

            #endregion

            #region 12. Get the most expensive price among each category's products.
            //var ExpenisveProduct = ProductList.GroupBy(p => p.Category)
            //         .Select(g => new { category = g.Key, Max = g.Max(g => g.UnitPrice) });
            //foreach (var max in ExpenisveProduct)
            //{
            //    Console.WriteLine($"{max.category},{max.Max}");
            //}
            #endregion

            #region 13. Get the products with the most expensive price in each category.

            //var mostExpensiveProducts = from p in ProductList
            //                            group p by p.Category into g
            //                            let maxPrice = g.Max(p => p.UnitPrice) 
            //                            from p in g
            //                            where p.UnitPrice == maxPrice 
            //                            select p;

            //foreach (var p in mostExpensiveProducts)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region  14.Get the average price of each category's products.
            var average = ProductList.GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, average = g.Average(g => g.UnitPrice) });

            #endregion
            #endregion

            #region  LINQ - Set Operators
            #region 1. Find the unique Category names from Product List
            var Uniuq = ProductList.DistinctBy(p => p.Category);
            foreach (var u in Uniuq)
            {
                Console.WriteLine(u);
            }
            #endregion
            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var resst;
            #endregion
            #endregion
            #region  LINQ - Partitioning Operators
            #region 1.Get the first 3 orders from customers in Washington
            var orderList = new List<Order>
        {
            new Order(1, new DateTime(2024, 2, 1), 150.00m, 1),
            new Order(2, new DateTime(2024, 2, 5), 200.50m, 2),
            new Order(3, new DateTime(2024, 2, 10), 99.99m, 3),
            new Order(4, new DateTime(2024, 2, 15), 300.00m, 4)
        };
            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            int[] numberss = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var resss = numberss.TakeWhile((number, index) => number > index);
            //foreach (var ress in resss)
            //{
            //    Console.WriteLine(ress);
            //}
            #endregion

            #region  4.Get the elements of the array starting from the first element divisible by 3.
            //var rest =numbers.SkipWhile(n=>n%3==0);
            //foreach(var resu in rest)
            //{
            //    Console.WriteLine(resu);
            //}
            #endregion
            Console.WriteLine("&&&&&&&&&&&&&&&");
            #region 5. Get the elements of the array starting from the first element less than its position.
            var TRes = numberss.SkipWhile((num, index) => num < index);

            foreach (var resu in TRes)
            {
                Console.WriteLine(resu);
            }

            #endregion
            #endregion

            #region LINQ - Quantifiers
            #region 1.Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            var TResult =words.Any(w=>w.Contains("ei"));
            Console.WriteLine(TResult);
            #endregion
            
            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            var P = //Group By
                ProductList.GroupBy(p => p.Category)
                .Where(g => g.Any(p => p.UnitsInStock == 0))
                .Select(g => new { 
                 Category=g.Key,
                  Products=g.ToList()});
            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            var AllProducts = ProductList.GroupBy(p => p.Category)
         .Where(g => g.All(p => p.UnitsInStock > 1))
         .Select(g => new { Category = g.Key, Products = g.ToList() });
            #endregion
            #endregion
            #region Grouping Operators
            #region Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbs = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = numbs.GroupBy(n => n % 5); 

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Remainder {group.Key}: /*{string.Join(", ", group)}*\");
            //}

            #endregion

            #region Uses group by to partition a list of words by their first letter.
            //Use dictionary_english.txt for Input
            var groupedWords = words.GroupBy(w => w.First());
            foreach (var group in groupedWords)
            {
                Console.WriteLine($"Words that start with '{group.Key}':");
                foreach (var word in group)
                {
                    Console.WriteLine($"  {word}");
                }
                Console.WriteLine("==========================================");
            }
            #endregion


            #region Consider this Array as an Input
          
            #endregion
            #endregion
        }

    }
}