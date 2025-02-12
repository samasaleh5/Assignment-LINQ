using static Assignment_LINQ.ListGenerators;
using System.Linq;
namespace Assignment_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            var result = ProductList.Where(P => P.UnitsInStock == 0);
            #endregion

            foreach (var item in result)
            {
                Console.WriteLine($"{item}");

            }

        }
    }
}
