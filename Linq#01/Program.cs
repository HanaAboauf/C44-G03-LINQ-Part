using static Linq_01.Data.ListGenerator;
namespace Linq_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region Question01

            //var results= ProductList?.Where(p => p.UnitsInStock == 0);

            //foreach (var Item in results ?? Enumerable.Empty<object>())
            //    Console.WriteLine(Item);

            #endregion

            #region Question02

            //var results = ProductList?.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);

            //foreach (var Item in results ?? Enumerable.Empty<object>())
            //    Console.WriteLine(Item);
            #endregion

            #region Question03

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var results = Arr.Where((s,i)=>s.Length<i);
            //foreach (var Item in results ?? Enumerable.Empty<object>())
            //    Console.WriteLine(Item);

            #endregion


            #endregion

            #region LINQ - Ordering Operators

            #region Question01



            //var results= from p in ProductList
            //             orderby p.ProductName
            //             select p;
            //foreach (var Item in results ?? Enumerable.Empty<object>())
            //    Console.WriteLine(Item);


            #endregion

            #region Question02

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var results = Arr.OrderBy(s => s, StringComparer.OrdinalIgnoreCase);

            //foreach (var Item in results ?? Enumerable.Empty<object>())
            //    Console.WriteLine(Item);
            #endregion

            #endregion
        }
    }
}
