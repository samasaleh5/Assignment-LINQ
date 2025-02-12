using static Assignment_LINQ.ListGenerators;
using System.Linq;
namespace Assignment_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ - Restriction Operators
            #region Q1
            // var result = ProductList.Where(P => P.UnitsInStock == 0);
            #endregion
            #region Q2
            // var result = ProductList.Where(P => P.UnitsInStock == 0 && P.UnitPrice>3.00m);
            #endregion
            #region Q3
            // String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            // var result = Arr.Select((name, index) => new { Name = name, Index = index }).Where(item => item.Name.Length < item.Index);
            #endregion

            //LINQ - Element Operators
            #region Q1
            //var result = ProductList.FirstOrDefault(P=>P.UnitsInStock==0);
            //if (result == null)
            //    Console.WriteLine("NO Product OutOfStock");
            //else
            //    Console.WriteLine($"First OutOfStockProduct is {result.ProductName}");
            #endregion
            #region Q2
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //if (result !!= null)
            //    Console.WriteLine($"First product over 1000: {result.ProductName} - ${result.UnitPrice}");
            //else
            //    Console.WriteLine("NO Product Found with Price Over 1000");
            #endregion
            #region Q3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Arr.Where(n=>n>5).Skip(1).FirstOrDefault();
            //Console.WriteLine(result);
            #endregion

            //LINQ - Aggregate Operators
            #region Q1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Arr.Count(n=>n%2==0);
            //Console.WriteLine(result);
            #endregion
            #region Q2

            //var result = CustomerList.Select(c => new
            //{
            //    customer = c.CustomerName,
            //    order = c.Orders.Count()
            //});
            #endregion
            #region Q3
            //var result = ProductList.Select(p => new
            //{
            //        Category = p.Category,
            //        ProductNumber = p.ProductName.Count(),
            //});
            #endregion
            #region Q4
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result=Arr.Count();
            Console.WriteLine(result);
            #endregion




            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");

            //}

        }
    }
}
