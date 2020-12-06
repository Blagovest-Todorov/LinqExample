using System;
using System.Linq;

namespace _12.LinqQuerry
{
    class Program
    {
        // Data source
        static void Main(string[] args)
        {
            string[] names = { "Bill", "Steves", "James", "Mohan" };

            //Linq querry 
            var myLinqQWuerry = from name in names
                                where name.Contains('a')
                                select name;

            // querry execution
            foreach (var name in myLinqQWuerry)
            {
                Console.WriteLine(name + " ");
            } // Linq querry is executed when iterated the foreach loop /
              // the foreach queery executes the querry on the data source and get teh result.



            //Advantages of LINQ

            // Developers don’t have to learn a new query language for each type of data source or data format.

            //  Less coding: It reduces the amount of code to be written as compared with a more traditional approach.

            //Readable code: LINQ makes the code more readable so other developers can easily understand and maintain it.

            // Standardized way of querying multiple data sources: The same LINQ syntax can be used to query multiple data sources.

            // Compile time safety of queries: It provides type checking of objects at compile time.

            //IntelliSense Support: LINQ provides IntelliSense for generic collections.

            //Shaping data: You can retrieve data in different shapes.

            // https://www.tutorialsteacher.com/linq/why-linq
        }
    }
}
