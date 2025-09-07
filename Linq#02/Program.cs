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

            #region Question03

            //3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where(a => a > 5).Skip(1).FirstOrDefault();

            //Console.WriteLine(result);

            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region Question01

            //1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result=Arr.Count(c=>c%2!=0);
            //Console.WriteLine(result); 
            #endregion

            #region Question02

            //Return a list of customers and how many orders each has.

            //var result= CustomerList?.Select(c=> new
            //{
            //    customerId=c.CustomerID,
            //    noOfOrders=c.Orders.Count()
            //}

            //);

            //foreach (var item in result??Enumerable.Empty<object>())
            //    Console.WriteLine(item);

            #endregion

            #region Question03

            //Return a list of categories and how many products each has

            //var result = ProductList?.GroupBy(p => p.Category).Select(g => new{
            //                                                                 Category = g.Key,
            //                                                                 ProductCount = g.Count()
            //                                                          });

            //foreach (var item in result ?? Enumerable.Empty<object>())
            //    Console.WriteLine(item);

            #endregion

            #region Question04

            //Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result= Arr.Sum(x => x);

            //Console.WriteLine(result);

            #endregion

            #region Question05

            //string filePath = "dictionary_english.txt";

            //string[] words = File.ReadAllLines(filePath);

            //// Get the total number of characters of all words in dictionary_english.txt 

            //var result=words.Sum(w=>w.Length);
            //Console.WriteLine(result);


            #endregion

            #region Question06

            //Get the length of the shortest word in dictionary_english.txt

            //string filePath = "dictionary_english.txt";

            //string[] words = File.ReadAllLines(filePath);

            //var result = words.Min(x => x.Length);

            //Console.WriteLine(result);

            #endregion

            #region Question07

            //Get the length of the longest word in dictionary_english.txt 

            //string filePath = "dictionary_english.txt";

            //string[] words = File.ReadAllLines(filePath);

            //var result = words.Max(x => x.Length);

            //Console.WriteLine(result);

            #endregion

            #region Question08

            //Get the average length of the words in dictionary_english.txt

            //string filePath = "dictionary_english.txt";

            //string[] words = File.ReadAllLines(filePath);


            //var result = words.Average(x => x.Length);

            //Console.WriteLine(result);

            #endregion

            #region Question09

            //Get the total units in stock for each product category.

            //var result = ProductList?.GroupBy(p=>p.Category).Sum(g=>g.Count());

            //Console.WriteLine(result);

            #endregion

            #region Question10

            //Get the cheapest price among each category's products

            //var result = ProductList?.GroupBy(p => p.Category).Select(g => new
            //{
            //    Category = g.Key,
            //    CheapestPrice = g.Min(p => p.UnitPrice)
            //}).Min(c=>c.CheapestPrice);
            //Console.WriteLine(result);
            #endregion

            #region Question11

            //Get the products with the cheapest price in each category (Use Let)

            //var result= from p in ProductList
            //            group p by p.Category into g
            //            let cheapestPrice=g.Min(p=>p.UnitPrice)
            //            from prod in g
            //            where prod.UnitPrice == cheapestPrice
            //            select new
            //            {
            //                Category = g.Key,
            //                ProductName = prod.ProductName,
            //                UnitPrice = prod.UnitPrice
            //            };

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion



            #endregion
        }
    }
}
