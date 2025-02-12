using static Assignment_LINQ.ListGenerators;
using System.Linq;
namespace Assignment_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // var result = ProductList.Where(P => P.UnitsInStock == 0);
            #endregion
            #region Q2
            // var result = ProductList.Where(P => P.UnitsInStock == 0 && P.UnitPrice>3.00m);
            #endregion
            #region Q3
            String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var result = Arr.Select((name, index) => new { Name = name, Index = index }).Where(item => item.Name.Length < item.Index);
            #endregion

            foreach (var item in result)
            {
                Console.WriteLine($"{item}");

            }

        }
    }
}
