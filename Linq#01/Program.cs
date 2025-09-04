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


            #endregion
        }
    }
}
