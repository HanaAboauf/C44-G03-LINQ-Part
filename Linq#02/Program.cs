using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using static Linq_02.Data.ListGenerator;
using static Linq_02.Data.Order;
using static System.Net.Mime.MediaTypeNames;

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

            #region Question12

            //Get the most expensive price among each category's products.


            //var result = ProductList?.GroupBy(p => p.Category).Select(g => new
            //{
            //    category=g.Key,
            //    price=g.Max(p=>p.UnitPrice),
            //});
            //foreach (var item in result??Enumerable.Empty<object>())
            //    Console.WriteLine(item);




            #endregion

            #region Question13

            //var result = ProductList?.GroupBy(p => p.Category).SelectMany(g =>
            //{
            //    var maxPrice = g.Max(p => p.UnitPrice);
            //    return g.Where(p => p.UnitPrice == maxPrice)
            //            .Select(p => new
            //            {
            //                Category = g.Key,
            //                ProductName = p.ProductName,
            //                UnitPrice = p.UnitPrice
            //            });
            //});

            //foreach (var item in result??Enumerable.Empty<object>())
            //    Console.WriteLine(item);



            #endregion

            #region Question14

            //Get the average price of each category's products.

            //var result = ProductList?.GroupBy(p => p.Category).Select(g => new
            //{
            //    category=g.Key,
            //    avgPrice=g.Average(p=>p.UnitPrice),
            //});

            //foreach (var item in result??Enumerable.Empty<object>())
            //    Console.WriteLine(item);

            #endregion




            #endregion

            #region LINQ - Set Operators

            #region Question01

            //Find the unique Category names from Product List

            //var result=ProductList?.Select(p=>p.Category).Distinct();


            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Question02

            //Produce a Sequence containing the unique first letter from both product and customer names.

            //var result = ProductList?.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Question03

            //Create one sequence that contains the common first letter from both product and customer names.

            //var result = ProductList?.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion

            #region Question04

            //Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var result = ProductList?.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Question05

            // Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //        var result = ProductList
            //.Select(p => p.ProductName.Length >= 3
            //             ? p.ProductName.Substring(p.ProductName.Length - 3)
            //             : p.ProductName)  
            //.Concat(CustomerList
            //    .Select(c => c.CustomerName.Length >= 3
            //                 ? c.CustomerName.Substring(c.CustomerName.Length - 3)
            //                 : c.CustomerName)); 

            //        foreach (var s in result)
            //        {
            //            Console.WriteLine(s);
            //        }


            #endregion

            #endregion

            #region LINQ - Partitioning Operators

            #region Question01

            //. Get the first 3 orders from customers in Washington

            //var result = CustomerList.Where(c => c.Region == "WA").SelectMany(c => c.Orders).Where(o => o != null).Take(3);

            //foreach (var item in result)
            //    Console.WriteLine(item.OrderID);


            #endregion

            #region Question02

            //Get all but the first 2 orders from customers in Washington.

            //var result=CustomerList.Where(c=>c.Region=="WA").SelectMany(c=>c.Orders).Where(o=>o!=null).Skip(2);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.OrderID);
            //}




            #endregion

            #region Question03
            // Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((num,i)=>num>i);

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region Question04

            //Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result=numbers.SkipWhile(n => n % 3 != 0); 

            //foreach (var item in result)
            //    Console.WriteLine(item);



            #endregion

            #region Question05

            // Get the elements of the array starting from the first element less than its position.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((n, i) => n > i);

            //foreach ( var n in numbers) 
            //    Console.WriteLine(n);

            #endregion

            #endregion

            #region LINQ - Quantifiers

            #region Question01
            //Determine if any of the words in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string filePath = "dictionary_english.txt";

            //string[] words = File.ReadAllLines(filePath);

            //var result = words.Any(w => w.Contains("ei"));

            //Console.WriteLine(result);


            #endregion

            #region Question02
            //Return a grouped list of products only for categories that have at least one product that is out of stock.

            //     var result = ProductList?
            //.Where(p => p.UnitsInStock == 0) 
            //.GroupBy(p => p.Category, p => p.ProductName);

            //     foreach (var group in result)
            //     {
            //         Console.WriteLine($"Category: {group.Key}");
            //         foreach (var productName in group)
            //         {
            //             Console.WriteLine($"   {productName}");
            //         }
            //     }




            #endregion

            #region Question03

            //Return a grouped list of products only for categories that have all of their products in stock.

            //     var result = ProductList?
            //.Where(p => p.UnitsInStock != 0) 
            //.GroupBy(p => p.Category, p => p.ProductName);

            //     foreach (var group in result)
            //     {
            //         Console.WriteLine($"Category: {group.Key}");
            //         foreach (var productName in group)
            //         {
            //             Console.WriteLine($"   {productName}");
            //         }
            //     }


            #endregion


            #endregion

            #region LINQ – Grouping Operators

            #region Question01
            //Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result=numbers.GroupBy(n => n % 5);

            //int chunk = 0;

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Numbers with reminder of {chunk++} when divided by 5:");
            //    foreach (var num in group)
            //    {
            //        Console.WriteLine($"{num}");
            //    }
            //}



            #endregion

            #region Question02

            //Uses group by to partition a list of words by their first letter.
            //Use dictionary_english.txt for Input

            //string filePath = "dictionary_english.txt";

            //string[] words = File.ReadAllLines(filePath);

            //var result = words.GroupBy(w => char.ToUpper(w[0]));

            //int chunk=1;

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Group: '{chunk++}':");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine($"{word}");
            //    }
            //}



            #endregion

            #region Question03

            //Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //string[] Arr = { "from", "salt", "earn", " last", "near", "form" };

            //var result = Arr.GroupBy(word => new string(word.Trim().OrderBy(c => c).ToArray()) );

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Group: {group.Key}");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine($"   {word}");
            //    }
            //}



            #endregion

            #endregion
        }
    }
}
