using static Linq_02.Data.ListGenerator;
using static Linq_02.Data.Order;

namespace Linq_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators

            #region Question01

            //1. Get first Product out of Stock 

            //var result = ProductList?.First(p=>p.UnitsInStock==0);

            //Console.WriteLine(result);




            #endregion

            #region Question02

            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var result = ProductList?.FirstOrDefault(p => p.UnitPrice > 1000);

            //Console.WriteLine(result);


            #endregion

            #endregion
        }
    }
}
