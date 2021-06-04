using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            numbers.Where(n => n % 2 == 0).ToList().ForEach(f => Console.WriteLine(f));

            Console.ReadKey();
        }
    }
}
