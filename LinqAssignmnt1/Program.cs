using static LinqDemo.ListGenerator;
namespace LinqAssignmnt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                #region Assignment
                #region Q1
                var result = ProductList.Where(p => p.UnitsInStock == 0);

                #endregion

                #region Q2
                //result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice>3.00M);
                //foreach (var unit in result)
                //{
                //    Console.WriteLine(unit);
                //}
                #endregion

                #region  Returns digits whose name is shorter than their value.

                //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

                //var resut = Arr
                //.Select((name, index) => new { Name = name, Value = index })  
                //.Where(item => item.Name.Length < item.Value)                 
                //.Select(item => $"{item.Value} ({item.Name})");
                #endregion

                #region  Sort a list of products by name
                //var Listed = ProductList.OrderBy(P => P.ProductName);
                //foreach (var unit in Listed)
                //{
                //    Console.WriteLine(unit);
                //}

                #endregion

                #region  Uses a custom comparer to do a case-insensitive sort of the words in an array.
                string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };


                Array.Sort(Arr, new CaseInsensitiveComparer());



                #endregion

                #region 3. Sort a list of products by units in stock from highest to lowest.
                var listedProdcusts = ProductList.OrderByDescending(p => p.UnitsInStock);

                #endregion

                #region ort a list of digits, first by length of their name, and then alphabetically by the name itself.
                string[] Arr1 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

                var lisybynamethenbyname = Arr1.OrderBy(Aword => Aword.Length)
                      .ThenBy(word => word);
                #endregion

                #region Sort first by word length and then by a case-insensitive sort of the words in an array.
                string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry", "a", "b", "C", "D" };
                CaseInsensitiveComparer caseInsensitiveComparer = new CaseInsensitiveComparer();
                var sorted = words.OrderBy(words => words.Length).ThenBy(caseInsensitiveComparer => caseInsensitiveComparer);


                #endregion

                #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

                var List_Products = ProductList.OrderBy(P => P.Category).ThenByDescending(p => p.UnitPrice);


                #endregion

                #region 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
                //string[] Arr2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

                //var SortedF = Arr2.OrderBy(p => p.Length).ThenByDescending(p => p, new CaseInsensitiveComparer());
                //foreach (var word in SortedF)
                //{
                //    Console.WriteLine(word);
                //}
                #endregion

                #region  Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
                string[] Arr3 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

                var filteredReversed = Arr3
                 .Where(word => word[1] == 'i')  // Check if the second letter is 'i'
                 .Reverse();
                foreach (var word in filteredReversed)
                {
                    Console.WriteLine(word);
                }
                #endregion
                #region 1. Return a sequence of just the names of a list of products.
                var ProductNames = ProductList.Select(p => p.ProductName);

                #endregion

                #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
                string[] wordss = { "aPPLE", "BlUeBeRrY", "cHeRry" };
                var Upper_Lower = words.Select(word => new

                {
                    Upper = word.ToUpper(),
                    lower = word.ToLower()
                });

                #endregion

                #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
                var products = ProductList.Select(p => new
                {
                    prudctName = p.ProductName,
                    Price = p.UnitPrice
                });
                foreach (var product in products)
                {
                    Console.WriteLine(product);
                }

                #endregion
                #region 4. Determine if the value of ints in an array match their position in the array.
                int[] Arr6 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                var result3 = Arr6.Select((value, index) => new
                {
                    Numb = value,
                    InPlace = value == index
                });
                foreach (var word in result3)
                {
                    Console.WriteLine(word);
                }

                #endregion

                #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

                int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
                int[] numbersB = { 1, 3, 5, 7, 8 };
                var FinalRes = from a in numbersA
                               from b in numbersB
                               where a > b
                               select (a, b);
                #endregion

                #region  Select all orders where the order total is less than 500.00.
                var filteredOrders = from customer in CustomerList
                                     from order in customer.Orders
                                     where order.Total < 500.00m
                                     select new
                                     {
                                         customer.CustomerName,
                                         order.OrderID,
                                         order.Total
                                     };
                foreach (var order in filteredOrders)
                {
                    Console.WriteLine($"Customerrrrrrrrrr {order.CustomerName}, OrderID {order.OrderID}, Total {order.Total}");
                }

                #endregion

                #region Select all orders where the order was made in 1998 or later.
                var after1998Orders = from customer in CustomerList
                                      from orders in customer.Orders
                                      where orders.OrderDate.Year >= 1998
                                      select new
                                      {
                                          orderiddd = orders.OrderID,
                                          orders.OrderDate

                                      };
                foreach (var order in after1998Orders)
                {
                    Console.WriteLine(order);
                }
                #endregion
                #endregion

            }
        }
    }
}
