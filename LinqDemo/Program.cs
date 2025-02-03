using System;
using System.Diagnostics.Tracing;
using System.Reflection;
using static LinqDemo.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Fluent syntax (code c sharp) static
            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,11};
            //List<int> ODDNumbers = Enumerable.Where<int>(list, i => i % 2 == 1).ToList();
            ////==
            //var ODDNumberss = Enumerable.Where<int>(list, i => i % 2 == 1);

            #endregion
            #region Fluent  Linq As extendos metiohd
            //var odd = list.Where(N => N % 2 == 1);
            #endregion
            #region Query syntax has specific order like sql must begin with select
            //var QueryEven = from N in list
            //               where N % 2 == 0
            //               select N;

            #endregion
            #region Linq Execution way
            //1.Differed Execu(not immediate)
            //List<int> Numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            //var Result = Numbers.Where(N => N % 2 == 0); //so  it havent executed yet
            //Numbers.AddRange(new int[] { 16, 17, 18, 19, 20 });
            //foreach(var N in Result)
            //{
            //    Console.WriteLine(N);
            //}
            ////2 Immediate Execution(elemnt/casting/aggregtae)

            //var ResultImmediate = Numbers.Where(N => N % 2 == 0).ToList(); //so  it havent executed yet
            //Numbers.AddRange(new int[] { 16, 17, 18, 19, 20 });
            //foreach (var N in ResultImmediate)
            //{
            //    Console.WriteLine(N);
            ////}
            #endregion

            #region Data SetUp
            //to connect on database we need ORM
            //Now local Sequnce
            #endregion
            #region Data Filteration
            var Result = ProductList.Where<Product>(p => p.UnitsInStock == 1).ToList();
            //INdexed where
            //get top
            //10 proecuts where u of stock valid only with fluent
            Result = ProductList.Where((P, I) => I < 10 && P.UnitsInStock == 1).ToList();


            #endregion

            #region Transfomation Operators(Projection)
            //var res = ProductList.Where(p => p.UnitsInStock > 1)
            //                   .Select(
            //   p => new { p.ProductID, p.ProductName });

            ////selectMany
            //// var orders = CustomerList.SelectMany(C => C.Orders!, (Customer, Order) => new { Customer,Order });
            //var orders = from C in CustomerList
            //             from o in C.Orders
            //             select new { Customer= C, orders= o };
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}

            #endregion

            #region Ordering Operations
            // var OrderDsesc = ProductList.OrderBy(P=>P.UnitPrice>1000).ThenBy(P=>P.ProductID);
            #endregion


            
        }
    }
}
